// Script để tạo app icon PNG từ SVG
// Dùng ffmpeg hoặc ImageMagick (nếu cài sẵn)
// Hoặc upload SVG lên https://www.aconvert.com/image/svg-to-png/ và download

// Cách dùng:
// 1. Upload assets/icons/app_icon.svg lên https://www.aconvert.com/image/svg-to-png/
// 2. Tạo size 512x512 PNG
// 3. Lưu file app_icon.png vào assets/icons/ folder

// Hoặc dùng ImageMagick (Windows):
// convert -background none -resize 512x512 assets/icons/app_icon.svg assets/icons/app_icon.png

// Hoặc dùng ffmpeg (nếu cài sẵn):
// ffmpeg -i assets/icons/app_icon.svg -vf scale=512:512 assets/icons/app_icon.png
