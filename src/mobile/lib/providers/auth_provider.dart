import 'package:riverpod_annotation/riverpod_annotation.dart';
import 'package:sohome/entities/user_token.dart';

part 'auth_provider.g.dart';

@riverpod
Future<UserToken?> isAuthenticated(Ref ref) {
  return Future.value(null);
}
