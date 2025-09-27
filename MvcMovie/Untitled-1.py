class Sinhvien:
    def __init__(self,msv, hodem, ten, ngaysinh, gioitinh, noisinh, malop):
        self.msv = msv
        self.hodem = hodem
        self.ten = ten
        self.ngaysinh = ngaysinh
        self.gioitinh = gioitinh
        self.noisinh = noisinh
        self.malop = malop
       
    def thongtin_sinhvien(self):
        print(f'MSV: {self.msv}')
        print(f'Họ tên: {self.hodem} {self.ten}')
        print(f'Ngày sinh: {self.ngaysinh}')
        print(f'Giới tính: {self.gioitinh}')
        print(f'Nơi sinh: {self.noisinh}')
        print(f'Mã lớp: {self.malop}')