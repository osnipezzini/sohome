// dart format width=80
// coverage:ignore-file
// GENERATED CODE - DO NOT MODIFY BY HAND
// ignore_for_file: type=lint
// ignore_for_file: unused_element, deprecated_member_use, deprecated_member_use_from_same_package, use_function_type_syntax_for_parameters, unnecessary_const, avoid_init_to_null, invalid_override_different_default_values_named, prefer_expression_function_bodies, annotate_overrides, invalid_annotation_target, unnecessary_question_mark

part of 'user_token.dart';

// **************************************************************************
// FreezedGenerator
// **************************************************************************

// dart format off
T _$identity<T>(T value) => value;

/// @nodoc
mixin _$UserToken {

 String get accessToken; String? get refreshToken; List<String> get roles;
/// Create a copy of UserToken
/// with the given fields replaced by the non-null parameter values.
@JsonKey(includeFromJson: false, includeToJson: false)
@pragma('vm:prefer-inline')
$UserTokenCopyWith<UserToken> get copyWith => _$UserTokenCopyWithImpl<UserToken>(this as UserToken, _$identity);

  /// Serializes this UserToken to a JSON map.
  Map<String, dynamic> toJson();


@override
bool operator ==(Object other) {
  return identical(this, other) || (other.runtimeType == runtimeType&&other is UserToken&&(identical(other.accessToken, accessToken) || other.accessToken == accessToken)&&(identical(other.refreshToken, refreshToken) || other.refreshToken == refreshToken)&&const DeepCollectionEquality().equals(other.roles, roles));
}

@JsonKey(includeFromJson: false, includeToJson: false)
@override
int get hashCode => Object.hash(runtimeType,accessToken,refreshToken,const DeepCollectionEquality().hash(roles));

@override
String toString() {
  return 'UserToken(accessToken: $accessToken, refreshToken: $refreshToken, roles: $roles)';
}


}

/// @nodoc
abstract mixin class $UserTokenCopyWith<$Res>  {
  factory $UserTokenCopyWith(UserToken value, $Res Function(UserToken) _then) = _$UserTokenCopyWithImpl;
@useResult
$Res call({
 String accessToken, String? refreshToken, List<String> roles
});




}
/// @nodoc
class _$UserTokenCopyWithImpl<$Res>
    implements $UserTokenCopyWith<$Res> {
  _$UserTokenCopyWithImpl(this._self, this._then);

  final UserToken _self;
  final $Res Function(UserToken) _then;

/// Create a copy of UserToken
/// with the given fields replaced by the non-null parameter values.
@pragma('vm:prefer-inline') @override $Res call({Object? accessToken = null,Object? refreshToken = freezed,Object? roles = null,}) {
  return _then(_self.copyWith(
accessToken: null == accessToken ? _self.accessToken : accessToken // ignore: cast_nullable_to_non_nullable
as String,refreshToken: freezed == refreshToken ? _self.refreshToken : refreshToken // ignore: cast_nullable_to_non_nullable
as String?,roles: null == roles ? _self.roles : roles // ignore: cast_nullable_to_non_nullable
as List<String>,
  ));
}

}


/// @nodoc
@JsonSerializable()

class _UserToken extends UserToken {
  const _UserToken({required this.accessToken, this.refreshToken, required final  List<String> roles}): _roles = roles,super._();
  factory _UserToken.fromJson(Map<String, dynamic> json) => _$UserTokenFromJson(json);

@override final  String accessToken;
@override final  String? refreshToken;
 final  List<String> _roles;
@override List<String> get roles {
  if (_roles is EqualUnmodifiableListView) return _roles;
  // ignore: implicit_dynamic_type
  return EqualUnmodifiableListView(_roles);
}


/// Create a copy of UserToken
/// with the given fields replaced by the non-null parameter values.
@override @JsonKey(includeFromJson: false, includeToJson: false)
@pragma('vm:prefer-inline')
_$UserTokenCopyWith<_UserToken> get copyWith => __$UserTokenCopyWithImpl<_UserToken>(this, _$identity);

@override
Map<String, dynamic> toJson() {
  return _$UserTokenToJson(this, );
}

@override
bool operator ==(Object other) {
  return identical(this, other) || (other.runtimeType == runtimeType&&other is _UserToken&&(identical(other.accessToken, accessToken) || other.accessToken == accessToken)&&(identical(other.refreshToken, refreshToken) || other.refreshToken == refreshToken)&&const DeepCollectionEquality().equals(other._roles, _roles));
}

@JsonKey(includeFromJson: false, includeToJson: false)
@override
int get hashCode => Object.hash(runtimeType,accessToken,refreshToken,const DeepCollectionEquality().hash(_roles));

@override
String toString() {
  return 'UserToken(accessToken: $accessToken, refreshToken: $refreshToken, roles: $roles)';
}


}

/// @nodoc
abstract mixin class _$UserTokenCopyWith<$Res> implements $UserTokenCopyWith<$Res> {
  factory _$UserTokenCopyWith(_UserToken value, $Res Function(_UserToken) _then) = __$UserTokenCopyWithImpl;
@override @useResult
$Res call({
 String accessToken, String? refreshToken, List<String> roles
});




}
/// @nodoc
class __$UserTokenCopyWithImpl<$Res>
    implements _$UserTokenCopyWith<$Res> {
  __$UserTokenCopyWithImpl(this._self, this._then);

  final _UserToken _self;
  final $Res Function(_UserToken) _then;

/// Create a copy of UserToken
/// with the given fields replaced by the non-null parameter values.
@override @pragma('vm:prefer-inline') $Res call({Object? accessToken = null,Object? refreshToken = freezed,Object? roles = null,}) {
  return _then(_UserToken(
accessToken: null == accessToken ? _self.accessToken : accessToken // ignore: cast_nullable_to_non_nullable
as String,refreshToken: freezed == refreshToken ? _self.refreshToken : refreshToken // ignore: cast_nullable_to_non_nullable
as String?,roles: null == roles ? _self._roles : roles // ignore: cast_nullable_to_non_nullable
as List<String>,
  ));
}


}

// dart format on
