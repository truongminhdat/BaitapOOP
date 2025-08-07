namespace SinhNhatConCho
{
    class LoaiXuong
    {
        public string TenXuong { get; set; }

        public LoaiXuong(string tenXuong)
        {
            TenXuong = tenXuong;
        }
    }

    class CucPhan
    {
        public string Mota { get; set; }

        public CucPhan(string mota)
        {
            Mota = mota;
        }
    }

    class ConCho
    {
        public string Ten { get; set; }
        public int Tuoi { get; set; }

        public void TuToChucSinhNhat()
        {
            Tuoi++;
            Console.WriteLine($"Gâu gâu! Hôm nay là sinh nhật của {Ten}! Bây giờ {Ten} đã {Tuoi} tuổi rồi");
        }

        public void ToChucSinhNhatConChoKhac(ConCho conChoKhac)
        {
            conChoKhac.Tuoi++;
            Console.WriteLine($"{Ten} vừa tổ chức sinh nhật cho {conChoKhac.Ten}! Chúc mừng sinh nhật {conChoKhac.Ten}, {conChoKhac.Tuoi} tuổi rồi!");
        }

        public void AnXuong(LoaiXuong xuong)
        {
            Console.WriteLine($"{Ten} đang ăn xương {xuong.TenXuong}");
        }

        public void AnNhieuXuong(List<LoaiXuong> danhSachXuong)
        {
            foreach (var xuong in danhSachXuong)
            {
                Console.WriteLine($"{Ten} đang ăn xương {xuong.TenXuong}");
            }
        }

        public CucPhan AnXuong2(LoaiXuong xuong)
        {
            Console.WriteLine($"{Ten} đang ăn xương {xuong.TenXuong}...");
            Console.WriteLine($"{Ten} đã tiêu hóa xong");

            string moTaPhan = $"Phân từ xương {xuong.TenXuong}";
            return new CucPhan(moTaPhan);
        }

        public List<CucPhan> AnNhieuXuong2(List<LoaiXuong> loaixuong)
        {
            List<CucPhan> danhsachPhan = new List<CucPhan>();
            foreach (var item in loaixuong)
            {
                Console.WriteLine($"{Ten} đang ăn xương {item.TenXuong}");
                Console.WriteLine($"{Ten} đã tiêu hóa xong");

                string moTaPhan = $"Phân từ xương {item.TenXuong}";
                danhsachPhan.Add(new CucPhan(moTaPhan));
            }
            return danhsachPhan;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            ConCho cho1 = new ConCho { Ten = "Mực", Tuoi = 2 };
            ConCho cho2 = new ConCho { Ten = "Bông", Tuoi = 3 };

            List<LoaiXuong> danhSachXuong = new List<LoaiXuong>
            {
                new LoaiXuong("Xương bò"),
                new LoaiXuong("Xương gà"),
                new LoaiXuong("Xương cá")
            };

            cho1.TuToChucSinhNhat();
            cho2.ToChucSinhNhatConChoKhac(cho1);
            cho1.AnXuong(danhSachXuong[0]);
            cho1.AnNhieuXuong(danhSachXuong);

            CucPhan phan1 = cho1.AnXuong2(danhSachXuong[0]);
            Console.WriteLine($"Đã tạo ra: {phan1.Mota}");

            List<CucPhan> danhSachPhan = cho2.AnNhieuXuong2(danhSachXuong);
            foreach (var phan in danhSachPhan)
            {
                Console.WriteLine($"Đã tạo ra: {phan.Mota}");
            }


            Console.ReadLine();
        }
    }
}
