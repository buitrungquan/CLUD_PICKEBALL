import 'package:flutter/material.dart';
import '../constants/constants.dart';

/// Pickleball Icon Widget - sử dụng Emoji + Custom Design
class PickleballIcon extends StatelessWidget {
  final String icon;
  final double size;
  final Color? color;
  final EdgeInsets padding;

  const PickleballIcon({
    Key? key,
    required this.icon,
    this.size = 24,
    this.color,
    this.padding = const EdgeInsets.all(0),
  }) : super(key: key);

  @override
  Widget build(BuildContext context) {
    return Padding(
      padding: padding,
      child: Text(
        icon,
        style: TextStyle(
          fontSize: size,
          color: color,
        ),
      ),
    );
  }
}

/// Modern Pickleball Card Widget
class PickleballCard extends StatelessWidget {
  final Widget child;
  final EdgeInsets padding;
  final double borderRadius;
  final BoxShadow? shadow;
  final Color? backgroundColor;
  final VoidCallback? onTap;
  final bool elevate;

  const PickleballCard({
    Key? key,
    required this.child,
    this.padding = const EdgeInsets.all(16),
    this.borderRadius = 16,
    this.shadow,
    this.backgroundColor,
    this.onTap,
    this.elevate = false,
  }) : super(key: key);

  @override
  Widget build(BuildContext context) {
    final isDark = Theme.of(context).brightness == Brightness.dark;
    
    return GestureDetector(
      onTap: onTap,
      child: Container(
        decoration: BoxDecoration(
          color: backgroundColor ?? (isDark ? PickleballColors.surface : Colors.white),
          borderRadius: BorderRadius.circular(borderRadius),
          boxShadow: [
            shadow ?? (elevate ? PickleballStyles.shadowMedium : PickleballStyles.shadowSmall),
          ],
        ),
        child: Padding(
          padding: padding,
          child: child,
        ),
      ),
    );
  }
}

/// Modern Pickleball Button with Icon
class PickleballButton extends StatelessWidget {
  final String label;
  final String? icon;
  final VoidCallback onPressed;
  final bool isPrimary;
  final bool isLoading;
  final double? width;
  final EdgeInsets padding;

  const PickleballButton({
    Key? key,
    required this.label,
    this.icon,
    required this.onPressed,
    this.isPrimary = true,
    this.isLoading = false,
    this.width,
    this.padding = const EdgeInsets.symmetric(vertical: 12, horizontal: 24),
  }) : super(key: key);

  @override
  Widget build(BuildContext context) {
    final backgroundColor = isPrimary ? PickleballColors.primary : PickleballColors.secondary;
    
    return SizedBox(
      width: width,
      child: ElevatedButton(
        onPressed: isLoading ? null : onPressed,
        style: ElevatedButton.styleFrom(
          backgroundColor: backgroundColor,
          foregroundColor: Colors.white,
          padding: padding,
          shape: RoundedRectangleBorder(
            borderRadius: PickleballStyles.radiusLarge,
          ),
          elevation: 4,
        ),
        child: isLoading
            ? SizedBox(
                height: 20,
                width: 20,
                child: CircularProgressIndicator(
                  valueColor: AlwaysStoppedAnimation(Colors.white),
                  strokeWidth: 2,
                ),
              )
            : Row(
                mainAxisSize: MainAxisSize.min,
                children: [
                  if (icon != null) ...[
                    PickleballIcon(icon: icon!, size: 20),
                    SizedBox(width: 8),
                  ],
                  Text(label, style: TextStyle(fontWeight: FontWeight.w600)),
                ],
              ),
      ),
    );
  }
}

/// Pickleball Header Section
class PickleballHeader extends StatelessWidget {
  final String title;
  final String subtitle;
  final String? icon;
  final Color? backgroundColor;

  const PickleballHeader({
    Key? key,
    required this.title,
    required this.subtitle,
    this.icon,
    this.backgroundColor,
  }) : super(key: key);

  @override
  Widget build(BuildContext context) {
    return Container(
      width: double.infinity,
      decoration: BoxDecoration(
        gradient: LinearGradient(
          colors: [
            backgroundColor ?? PickleballColors.primary,
            (backgroundColor ?? PickleballColors.primary).withOpacity(0.7),
          ],
          begin: Alignment.topLeft,
          end: Alignment.bottomRight,
        ),
        borderRadius: BorderRadius.only(
          bottomLeft: Radius.circular(24),
          bottomRight: Radius.circular(24),
        ),
      ),
      padding: EdgeInsets.all(PickleballStyles.spacingL),
      child: Column(
        crossAxisAlignment: CrossAxisAlignment.start,
        children: [
          if (icon != null)
            PickleballIcon(icon: icon!, size: 32, color: Colors.white),
          if (icon != null) SizedBox(height: PickleballStyles.spacingM),
          Text(
            title,
            style: TextStyle(
              fontSize: 28,
              fontWeight: FontWeight.bold,
              color: Colors.white,
            ),
          ),
          SizedBox(height: PickleballStyles.spacingS),
          Text(
            subtitle,
            style: TextStyle(
              fontSize: 14,
              color: Colors.white70,
            ),
          ),
        ],
      ),
    );
  }
}

/// Pickleball Stats Card
class PickleballStatCard extends StatelessWidget {
  final String icon;
  final String label;
  final String value;
  final Color? iconColor;

  const PickleballStatCard({
    Key? key,
    required this.icon,
    required this.label,
    required this.value,
    this.iconColor,
  }) : super(key: key);

  @override
  Widget build(BuildContext context) {
    return PickleballCard(
      child: Column(
        crossAxisAlignment: CrossAxisAlignment.start,
        children: [
          PickleballIcon(
            icon: icon,
            size: 28,
            color: iconColor ?? PickleballColors.primary,
          ),
          SizedBox(height: PickleballStyles.spacingM),
          Text(
            label,
            style: TextStyle(
              fontSize: 12,
              color: PickleballColors.textSecondary,
              fontWeight: FontWeight.w500,
            ),
          ),
          SizedBox(height: PickleballStyles.spacingS),
          Text(
            value,
            style: TextStyle(
              fontSize: 24,
              fontWeight: FontWeight.bold,
              color: PickleballColors.textPrimary,
            ),
          ),
        ],
      ),
    );
  }
}
