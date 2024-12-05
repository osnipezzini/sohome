// Copyright 2024 The Flutter team. All rights reserved.
// Use of this source code is governed by a BSD-style license that can be
// found in the LICENSE file.
import '../../../domain/models/user/user.dart';

class LocalDataService {


  User getUser() {
    return const User(
      name: 'Sofie',
      // For demo purposes we use a local asset
      picture: 'assets/user.jpg',
    );
  }
}