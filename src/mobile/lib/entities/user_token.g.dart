// GENERATED CODE - DO NOT MODIFY BY HAND

part of 'user_token.dart';

// **************************************************************************
// JsonSerializableGenerator
// **************************************************************************

_UserToken _$UserTokenFromJson(Map<String, dynamic> json) => _UserToken(
  accessToken: json['accessToken'] as String,
  refreshToken: json['refreshToken'] as String?,
  roles: (json['roles'] as List<dynamic>).map((e) => e as String).toList(),
);

Map<String, dynamic> _$UserTokenToJson(_UserToken instance) =>
    <String, dynamic>{
      'accessToken': instance.accessToken,
      'refreshToken': instance.refreshToken,
      'roles': instance.roles,
    };
