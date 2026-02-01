import 'package:flutter/material.dart';

/// Pickleball App Constants & Icons
class PickleballConstants {
  // App Info
  static const String appName = 'Vợt Thủ Phố Núi';
  static const String appSubtitle = 'Pickleball Club Management';
  
  // Asset Paths
  static const String assetsPath = 'assets/';
  static const String iconsPath = '${assetsPath}icons/';
  static const String imagesPath = '${assetsPath}images/';
  
  // Pickleball Icon Unicode & Descriptions
  static const String pickleballRacketIcon = '🏓';  // Paddles
  static const String pickleballBallIcon = '⚪';    // Ball
  static const String courtIcon = '🏟️';            // Court
  static const String trophyIcon = '🏆';           // Tournament
  static const String walletIcon = '💰';           // Wallet
  static const String userIcon = '👤';             // Member
  static const String profileIcon = '👤';          // Profile (same as userIcon)
  static const String calendarIcon = '📅';         // Booking
  static const String notificationIcon = '🔔';     // Notification
  static const String scoreIcon = '📊';            // Statistics
  static const String medalIcon = '🎖️';           // Ranking
}

/// Pickleball Modern Color Palette
class PickleballColors {
  // Primary Colors
  static const Color primary = Color(0xFF00D9A3);      // Vibrant Teal
  static const Color primaryLight = Color(0xFF5EEDCF);
  static const Color primaryDark = Color(0xFF009073);
  
  // Secondary Colors
  static const Color secondary = Color(0xFF5A3FA0);    // Deep Purple
  static const Color secondaryLight = Color(0xFF8B6BB5);
  static const Color secondaryDark = Color(0xFF3D2870);
  
  // Accent Colors
  static const Color accent = Color(0xFFFFB81C);       // Gold
  static const Color accentLight = Color(0xFFFFD54F);
  static const Color accentDark = Color(0xFFC79600);
  
  // Neutral Colors
  static const Color background = Color(0xFF0F1419);
  static const Color surface = Color(0xFF1A1F2E);
  static const Color surfaceLight = Color(0xFF2D3142);
  static const Color surfaceDark = Color(0xFF0F1419);
  
  // Status Colors
  static const Color success = Color(0xFF4CAF50);
  static const Color warning = Color(0xFFFFA500);
  static const Color error = Color(0xFFE53935);
  static const Color info = Color(0xFF2196F3);
  
  // Text Colors
  static const Color textPrimary = Color(0xFFFFFFFF);
  static const Color textSecondary = Color(0xFFB0B5C1);
  static const Color textDisabled = Color(0xFF757575);
}

/// Pickleball UI Styling
class PickleballStyles {
  // Border Radius
  static const BorderRadius radiusSmall = BorderRadius.all(Radius.circular(8));
  static const BorderRadius radiusMedium = BorderRadius.all(Radius.circular(12));
  static const BorderRadius radiusLarge = BorderRadius.all(Radius.circular(16));
  static const BorderRadius radiusXL = BorderRadius.all(Radius.circular(20));
  
  // Box Shadow
  static const BoxShadow shadowSmall = BoxShadow(
    color: Color(0x0D000000),
    blurRadius: 4,
    offset: Offset(0, 2),
  );
  
  static const BoxShadow shadowMedium = BoxShadow(
    color: Color(0x1A000000),
    blurRadius: 8,
    offset: Offset(0, 4),
  );
  
  static const BoxShadow shadowLarge = BoxShadow(
    color: Color(0x26000000),
    blurRadius: 12,
    offset: Offset(0, 6),
  );
  
  // Spacing
  static const double spacingXS = 4;
  static const double spacingS = 8;
  static const double spacingM = 12;
  static const double spacingL = 16;
  static const double spacingXL = 24;
  static const double spacing2XL = 32;
}
