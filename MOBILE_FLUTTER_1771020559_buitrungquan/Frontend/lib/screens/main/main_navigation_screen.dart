import 'package:flutter/material.dart';
import 'package:provider/provider.dart';
import '../../providers/providers.dart';
import '../../constants/constants.dart';
import '../../widgets/pickleball_widgets.dart';
import '../home/home_screen.dart';
import 'booking_screen.dart';
import 'tournaments_screen.dart';
import 'wallet_screen.dart';
import 'profile_screen.dart';

class MainNavigationScreen extends StatefulWidget {
  const MainNavigationScreen({super.key});

  @override
  State<MainNavigationScreen> createState() => _MainNavigationScreenState();
}

class _MainNavigationScreenState extends State<MainNavigationScreen> {
  int _currentIndex = 0;

  final List<Widget> _screens = [
    const HomeScreen(),
    const BookingScreen(),
    const TournamentsScreen(),
    const WalletScreen(),
    const ProfileScreen(),
  ];

  @override
  void initState() {
    super.initState();
    // Initialize providers
    context.read<NotificationProvider>()
      ..init()
      ..loadUnreadCount();
    context.read<WalletProvider>().loadBalance();
    context.read<BookingProvider>().loadCourts();
  }

  @override
  Widget build(BuildContext context) {
    final isDark = Theme.of(context).brightness == Brightness.dark;
    
    return Scaffold(
      body: IndexedStack(index: _currentIndex, children: _screens),
      bottomNavigationBar: Container(
        decoration: BoxDecoration(
          color: isDark ? PickleballColors.surfaceDark : Colors.white,
          boxShadow: [PickleballStyles.shadowMedium],
        ),
        child: BottomNavigationBar(
          currentIndex: _currentIndex,
          onTap: (index) => setState(() => _currentIndex = index),
          type: BottomNavigationBarType.fixed,
          backgroundColor: Colors.transparent,
          elevation: 0,
          selectedItemColor: PickleballColors.primary,
          unselectedItemColor: PickleballColors.textSecondary,
          selectedLabelStyle: const TextStyle(
            fontWeight: FontWeight.w600,
            fontSize: 12,
          ),
          items: [
            BottomNavigationBarItem(
              icon: PickleballIcon(
                icon: PickleballConstants.pickleballRacketIcon,
                size: 24,
              ),
              activeIcon: PickleballIcon(
                icon: PickleballConstants.pickleballRacketIcon,
                size: 28,
                color: PickleballColors.primary,
              ),
              label: 'Trang chủ',
            ),
            BottomNavigationBarItem(
              icon: PickleballIcon(
                icon: PickleballConstants.calendarIcon,
                size: 24,
              ),
              activeIcon: PickleballIcon(
                icon: PickleballConstants.calendarIcon,
                size: 28,
                color: PickleballColors.primary,
              ),
              label: 'Đặt sân',
            ),
            BottomNavigationBarItem(
              icon: PickleballIcon(
                icon: PickleballConstants.trophyIcon,
                size: 24,
              ),
              activeIcon: PickleballIcon(
                icon: PickleballConstants.trophyIcon,
                size: 28,
                color: PickleballColors.primary,
              ),
              label: 'Giải đấu',
            ),
            BottomNavigationBarItem(
              icon: PickleballIcon(
                icon: PickleballConstants.walletIcon,
                size: 24,
              ),
              activeIcon: PickleballIcon(
                icon: PickleballConstants.walletIcon,
                size: 28,
                color: PickleballColors.primary,
              ),
              label: 'Ví',
            ),
            BottomNavigationBarItem(
              icon: PickleballIcon(
                icon: PickleballConstants.profileIcon,
                size: 24,
              ),
              activeIcon: PickleballIcon(
                icon: PickleballConstants.profileIcon,
                size: 28,
                color: PickleballColors.primary,
              ),
              label: 'Cá nhân',
            ),
          ],
        ),
      ),
    );
  }
}
