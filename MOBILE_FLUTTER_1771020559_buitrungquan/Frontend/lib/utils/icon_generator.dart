import 'package:flutter/material.dart';

/// Simple SVG-like app icon generator
/// Tạo icon Pickleball bằng CustomPaint
void main() {
  runApp(const MyApp());
}

class MyApp extends StatelessWidget {
  const MyApp({Key? key}) : super(key: key);

  @override
  Widget build(BuildContext context) {
    return MaterialApp(
      home: Scaffold(
        body: Center(
          child: PickleballIconGenerator(size: 512),
        ),
      ),
    );
  }
}

/// Widget tạo Pickleball Icon
class PickleballIconGenerator extends StatelessWidget {
  final double size;
  const PickleballIconGenerator({Key? key, this.size = 192}) : super(key: key);

  @override
  Widget build(BuildContext context) {
    return CustomPaint(
      size: Size(size, size),
      painter: PickleballIconPainter(),
    );
  }
}

/// CustomPainter để vẽ icon Pickleball
class PickleballIconPainter extends CustomPainter {
  @override
  void paint(Canvas canvas, Size size) {
    final paint = Paint()..isAntiAlias = true;
    final center = Offset(size.width / 2, size.height / 2);
    final radius = size.width / 2;

    // Background gradient (Teal to Purple)
    final gradientPaint = Paint()
      ..shader = LinearGradient(
        colors: [
          const Color(0xFF00D9A3), // Teal
          const Color(0xFF5A3FA0), // Purple
        ],
        begin: Alignment.topLeft,
        end: Alignment.bottomRight,
      ).createShader(Rect.fromCircle(center: center, radius: radius));

    // Draw circular background
    canvas.drawCircle(center, radius, gradientPaint);

    // Draw Pickleball Racket in the center
    _drawPickleballRacket(canvas, center, radius * 0.5, paint);
  }

  void _drawPickleballRacket(
      Canvas canvas, Offset center, double size, Paint paint) {
    // Paddle (vợt)
    paint.color = Colors.white;
    paint.strokeWidth = 2;
    paint.style = PaintingStyle.stroke;

    // Oval paddle head
    canvas.drawOval(
      Rect.fromCenter(
        center: Offset(center.dx, center.dy - size * 0.3),
        width: size * 0.6,
        height: size * 0.7,
      ),
      paint,
    );

    // Handle (cán vợt)
    paint.strokeWidth = 3;
    canvas.drawLine(
      Offset(center.dx, center.dy - size * 0.1),
      Offset(center.dx, center.dy + size * 0.4),
      paint,
    );

    // Ball (bóng)
    paint.style = PaintingStyle.fill;
    paint.color = const Color(0xFFFFB81C); // Gold
    canvas.drawCircle(
      Offset(center.dx + size * 0.35, center.dy + size * 0.2),
      size * 0.15,
      paint,
    );
  }

  @override
  bool shouldRepaint(CustomPainter oldDelegate) => false;
}
