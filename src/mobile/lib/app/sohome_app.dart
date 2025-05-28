import 'package:flutter/material.dart';
import 'package:sohome/app/router.dart';

class SOHomeApp extends StatelessWidget {
  const SOHomeApp({super.key});

  // This widget is the root of your application.
  @override
  Widget build(BuildContext context) {
    return MaterialApp.router(
      title: 'SOHome',
      theme: ThemeData(
        colorScheme: ColorScheme.fromSeed(seedColor: Colors.deepPurple),
      ),
      routerConfig: router,
    );
  }
}
