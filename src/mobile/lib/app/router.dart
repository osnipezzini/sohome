import 'package:go_router/go_router.dart';
import 'package:sohome/app/routes.dart';
import 'package:sohome/pages/home_screen.dart';
import 'package:sohome/pages/login_screen.dart';
import 'package:sohome/pages/register_screen.dart';

final router = GoRouter(
  routes: [
    GoRoute(path: Routes.home, builder: (context, state) => HomeScreen()),
    GoRoute(path: Routes.login, builder: (context, state) => LoginScreen()),
    GoRoute(
      path: Routes.register,
      builder: (context, state) => RegisterScreen(),
    ),
  ],
);
