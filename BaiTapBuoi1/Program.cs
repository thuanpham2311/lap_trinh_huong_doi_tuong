// Phạm Tấn Thuận | DH51902283
// 1/ xóa phần tử có giá trị = x đầu tiên tìm thấy trong mảng
// VD: 1 2 4 5 2 6 ⇒ x = 2 ⇒ kết quả: 1 4 5 2 6
// 2/ thêm phần x tử tại vị trí pos.
// VD: 1 2 4 5 2 6 ⇒ x = 3 tại pos = 1 ⇒ kết quả: 1 3 2 4 5 2 6

using System;

namespace BaiTapBuoi1 {
  class Program {
    public static void NhapMang(int[] array, int number) {
      for (int i = 0; i < number; i++) {
        Console.Write("Nhập phần tử thứ " + (i + 1) + ": ");
        array[i] = Convert.ToInt32(Console.ReadLine());
      }
    }

    public static void XuatMang(int[] array, int number) {
      for (int i = 0; i < number; i++) {
        Console.Write(array[i] + "\t");
      }
    }

    public static void XoaPhanTuTrongMang(int[] array, ref int number, int viTriXoa) {
      viTriXoa--;
      while (viTriXoa < number) {
        array[viTriXoa] = array[viTriXoa + 1];
        viTriXoa++;
      }
      number--;
    }

    public static void ThemPhanTuTrongMang(int[] array, ref int number, int viTriThem,
                                           int soMuonThem) {
      viTriThem--;
      number++;
      for (int i = number; i >= viTriThem; i--) {
        array[i] = array[i - 1];
      }
      array[viTriThem] = soMuonThem;
    }

    static void Main(string[] args) {
      int[] array;
      int number;
      int viTriXoa;
      int viTriThem;
      int soMuonThem;

      Console.Write("Nhập số phần tử của mảng: ");
      number = Convert.ToInt32(Console.ReadLine());
      array = new int[number + 1];

      NhapMang(array, number);
      Console.Write("Phần tử có trong mảng:\n");
      XuatMang(array, number);

      Console.Write("\nNhập vị trí cần xóa của mảng: ");
      viTriXoa = Convert.ToInt32(Console.ReadLine());

      XoaPhanTuTrongMang(array, ref number, viTriXoa);

      Console.Write("Phần tử có trong mảng:\n");
      XuatMang(array, number);

      Console.Write("\nNhập vị trí cần thêm của mảng: ");
      viTriThem = Convert.ToInt32(Console.ReadLine());

      Console.Write("\nNhập số cần thêm vào mảng(vị trí pos): ");
      soMuonThem = Convert.ToInt32(Console.ReadLine());

      ThemPhanTuTrongMang(array, ref number, viTriThem, soMuonThem);

      Console.Write("Phần tử có trong mảng:\n");
      XuatMang(array, number);
    }
  }
}
