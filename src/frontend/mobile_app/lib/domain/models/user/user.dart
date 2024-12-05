import 'dart:convert';

class User {
  final String name;
  final String picture;

  const User({
    required this.name,
    required this.picture,
  });

  Map<String, Object?> toMap() {
    return {
      'name': name,
      'picture': picture,
    };
  }

  String toJson() {
    return jsonEncode(toMap());
  }

  @override
  String toString() {
    return 'User(name: $name, picture: $picture)';
  }

  factory User.fromJson(Map<String, Object?> json) {
    return User(
      name: json['name'] as String,
      picture: json['picture'] as String,
    );
  }

  factory User.fromMap(Map<String, Object?> map) {
    return User.fromJson(map);
  }
}