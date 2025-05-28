import 'package:freezed_annotation/freezed_annotation.dart';

part 'user_token.freezed.dart';
part 'user_token.g.dart';

@freezed
sealed class UserToken with _$UserToken {
  const UserToken._();

  const factory UserToken({
    required String accessToken,
    String? refreshToken,
    required List<String> roles,
  }) = _UserToken;

  factory UserToken.fromJson(Map<String, dynamic> json) =>
      _$UserTokenFromJson(json);
}
