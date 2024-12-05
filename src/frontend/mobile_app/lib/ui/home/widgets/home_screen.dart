// Copyright 2024 The Flutter team. All rights reserved.
// Use of this source code is governed by a BSD-style license that can be
// found in the LICENSE file.

import 'package:flutter/material.dart';
import 'package:go_router/go_router.dart';

import '../../../routing/routes.dart';
import '../../core/localization/applocalization.dart';
import '../../core/themes/dimens.dart';
import '../../core/ui/error_indicator.dart';
import '../view_models/home_viewmodel.dart';
import 'home_title.dart';

class HomeScreen extends StatefulWidget {
  const HomeScreen({
    super.key,
    required this.viewModel,
  });

  final HomeViewModel viewModel;

  @override
  State<HomeScreen> createState() => _HomeScreenState();
}

class _HomeScreenState extends State<HomeScreen> {
  @override
  Widget build(BuildContext context) {
    return Scaffold(
      floatingActionButton: FloatingActionButton.extended(
        // Workaround for https://github.com/flutter/flutter/issues/115358#issuecomment-2117157419
        heroTag: null,
        onPressed: () => context.go(Routes.search),
        label: Text(AppLocalization.of(context).bookNewTrip),
        icon: const Icon(Icons.add_location_outlined),
      ),
      body: SafeArea(
        top: true,
        bottom: true,
        child: ListenableBuilder(
          listenable: widget.viewModel.load,
          builder: (context, child) {
            if (widget.viewModel.load.running) {
              return const Center(
                child: CircularProgressIndicator(),
              );
            }

            if (widget.viewModel.load.error) {
              return ErrorIndicator(
                title: AppLocalization.of(context).errorWhileLoadingHome,
                label: AppLocalization.of(context).tryAgain,
                onPressed: widget.viewModel.load.execute,
              );
            }

            return child!;
          },
          child: ListenableBuilder(
            listenable: widget.viewModel,
            builder: (context, _) {
              return CustomScrollView(
                slivers: [
                  SliverToBoxAdapter(
                    child: Padding(
                      padding: EdgeInsets.symmetric(
                        vertical: Dimens.of(context).paddingScreenVertical,
                        horizontal: Dimens.of(context).paddingScreenHorizontal,
                      ),
                      child: HomeHeader(viewModel: widget.viewModel),
                    ),
                  ),
                ],
              );
            },
          ),
        ),
      ),
    );
  }
}