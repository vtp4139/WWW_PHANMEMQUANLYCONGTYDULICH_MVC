using System;
using System.Collections.Generic;
using TourManager.Models;

namespace TourManager.DAL
{
    public class AddData
    {
        public static List<Tour> getTours()
        {
            List<Tour> tours = new List<Tour>()
            {
                new Tour()
                {
                    TourName="Miền Tây - Tiền Giang - Cần Thơ - Sóc Trăng - Bạc Liêu",
                    DepartureDate = DateTime.Parse("2020/7/7"),
                    NumberOfDay = 4,
                    StartAddress ="Hồ Chí Minh",
                    Price = 3000000,
                    NumSeat = 30,
                    EmptySeat = 15,
                    TourType = true,
                    Describe = "Cà Mau - Bạc Liêu - Sóc Trăng 2 ngày 2 đêm từ Sài Gòn 2020 - Du khách sẽ được chu du miền Đất Mũi, nơi cuối cùng của tổ quốc để cảm nhận hết cái chất của vùng Đồng Bằng Sông Cửu Long rộng lớn với hệ sinh thái rừng ngập mặn rất đa dạng, ngắm cảnh thiên nhiên vả thưởng thức nhiều đặc sản hấp dẫn của mảnh đất địa cuối Tổ Quốc.",
                    Picture = "pic_01.jpg"
                },
                new Tour()
                {
                    TourName="Miền Tây - Cồn Sơn - Cần Thơ - chợ nổi Cái Răng",
                    DepartureDate = DateTime.Parse("2020/7/8"),
                    NumberOfDay = 2,
                    StartAddress ="Hồ Chí Minh",
                    Price = 1390000,
                    NumSeat = 15,
                    EmptySeat = 10,
                    TourType = true,
                    Describe ="Xuôi theo dòng nước du khách đến với chợ nổi Cái Răng để chứng kiến điều kì lạ, chợ mà nổi được trên sông? Du khách đi chợ nổi Cái Răng trên sông Cần Thơ không chỉ để ngắm nhìn những ghe thuyền đầy ắp hoa quả, hàng hóa mà còn để thưởng thức hương vị tô hủ tiếu hay tô bún cua thơm ngon giữa dòng nước mênh mông. Bên cạnh tham quan các Chợ nổi, du khách còn được viếng thăm Thiền Viện Trúc Lâm Phương Nam, Thiền Viện được xem là một trong những công trình nghệ thuật độc đáo của đất Tây Đô - ngôi chùa rộng nhất khu vực Đồng bằng sông Cửu Long, được xây dựng trên diện tích gần 4 ha, với kết cấu lợp ngói, khung cột gỗ lim, chánh điện rộng cùng nhà tổ, nhiều tượng Phật được làm bằng gỗ Du Sam. ",
                    Picture = "pic_02.png"
                },
                new Tour()
                {
                    TourName="Đà Nẵng - Bà Nà - Cầu Vàng - Sơn Trà - Biển Mỹ Khê - Hội An",
                    DepartureDate = DateTime.Parse("2020/7/10"),
                    NumberOfDay = 4,
                    StartAddress ="Hồ Chí Minh",
                    Price = 3000000,
                    NumSeat = 30,
                    EmptySeat = 15,
                    TourType = true,
                    Describe = "Khám phá trọn vẹn vẻ đẹp tạo hóa ban tặng cho dải đất miền Trung với hành trình du lịch Đà Nẵng - Bà Nà - Cầu Vàng - Sơn Trà - Biển Mỹ Khê - Hội An 4 ngày 3 đêm. Đặc biệt, với hành trình này du khách còn được hưởng những ưu đã hấp dẫn cùng Du Lịch Việt, chắc chắn sẽ mang đến cho du khách một chuyến đi trọn vẹn nhất!",
                    Picture = "pic_03.jpg"
                },
                new Tour()
                {
                    TourName="Hà Nội - Hạ Long- Sapa - Fansipan 4N3Đ",
                    DepartureDate = DateTime.Parse("2020/7/9"),
                    NumberOfDay = 4,
                    StartAddress ="Hồ Chí Minh",
                    Price = 6599000,
                    NumSeat = 20,
                    EmptySeat = 15,
                    TourType = true,
                    Describe = "Du lịch miền Bắc vẫn luôn là một lựa chọn ưu tiên dành cho các khách du lịch muốn trải nghiệm không khí núi rừng tại miền Bắc. Phong cảnh hữu tình, thiên nhiên và con người như hòa chung vào làm một chắc chắn sẽ là hành trình lý tưởng phải đến trong dịp đầu năm. Hãy cùng Du Lịch Việt tham khảo những điểm du lịch nhất định phải đi trong tour du lịch miền Bắc này với hành trình Hà Nội - Lào Cai - Sapa - Bản Cát Cát - chinh phục đỉnh Fansipan du khách nhé.",
                    Picture = "pic_04.jpg"
                },
                new Tour()
                {
                    TourName="Cam Ranh - Đảo Bình Ba",
                    DepartureDate = DateTime.Parse("2020/7/7"),
                    NumberOfDay = 4,
                    StartAddress ="Hồ Chí Minh",
                    Price = 2099000,
                    NumSeat = 15,
                    EmptySeat = 15,
                    TourType = true,
                    Describe = "Đảo Bình Ba có lẽ đó là một cái tên khá lạ lẫm đối với nhiều người, nhưng đối với dân du lịch bụi hay phượt thì đây là một điểm du lịch rất tuyệt vời. Bình Ba là một hòn đảo nhỏ thuộc Cam Ranh, Khánh Hòa, diện tích trên 3km vuông, cách Nha Trang 60km, cách thành phố Hồ Chí Minh khoảng 390km. Để đến được Bình Ba bạn phải đến cảng Ba Ngòi. Đây là một hòn đảo quân sự, trước đây cấm dân ngoài và người nước ngoài vào đảo nhưng bây giờ đã cho phép người Việt Nam đến nhưng vẫn cấm người nước ngoài, nhưng với điều kiện là không mò đến những khu vực cấm và không có những hành động quá khích. Chính vì điều này của Bình Ba, khiến cho nhiều người càng muốn thực hiện tour du lịch đảo Bình Ba để hiểu về nó nhiều hơn. Và chuyến du lịch đảo Bình Ba sẽ không làm bạn thất vọng bởi vẻ đẹp hoang sơ kỳ bí của nó.",
                    Picture = "pic_5.jpg"
                },
                new Tour()
                {
                    TourName="Du lịch Châu Âu - Pháp - Luxembourg - Bỉ - Hà Lan - Đức",
                    DepartureDate = DateTime.Parse("2020/7/10"),
                    NumberOfDay = 8,
                    StartAddress ="Hồ Chí Minh",
                    Price = 39990000,
                    NumSeat = 25,
                    EmptySeat = 10,
                    TourType = false,
                    Describe = "Du lịch Châu Âu mùa Xuân để tận mắt chiêm ngưỡng bức tranh mùa xuân tươi đẹp ở những thành phố nổi tiếng thế giới. Đặc biệt khi đến Hà Lan vào mùa xuân bạn sẽ được tham gia lễ hội hoa Keukenhof. Nơi được mệnh danh là khu vườn của Châu Âu với hàng triệu loài hoa đẹp khoe sắc tỏa hương. ",
                    Picture = "pic_6.jpg"
                },
                new Tour()
                {
                    TourName="Du lịch Nhật Bản mùa hoa Anh Đào",
                    DepartureDate = DateTime.Parse("2020/7/20"),
                    NumberOfDay = 6,
                    StartAddress ="Hồ Chí Minh",
                    Price = 41990000,
                    NumSeat = 20,
                    EmptySeat = 15,
                    TourType = false,
                    Describe = " Tour mùa hoa Anh Đào cứ mỗi độ xuân về, khi tiết trời trở nên ấm áp, Nhật Bản ngập trong sắc hồng và hương thêm dịu nhẹ của loài hoa sakura. Mùa xuân Nhật Bản thường bắt đầu từ tháng 3 và kéo dài đến tận tháng 5. Đây chính là thời điểm hoa Anh Đào khoe sắc, nở rộ nhất vào cuối tháng 3, đầu tháng 4.",
                    Picture = "pic_7.jpg"
                },
                new Tour()
                {
                    TourName="Du lịch Nhật Bản mùa Xuân Fukuoka - Kitakyushu - Kumamoto - Fukuoka",
                    DepartureDate = DateTime.Parse("2020/7/15"),
                    NumberOfDay = 4,
                    StartAddress ="Hà Nội",
                    Price = 24550000,
                    NumSeat = 15,
                    EmptySeat = 10,
                    TourType = false,
                    Describe = "Du lịch Nhật Bản mùa Xuân cùng TravelIUH khám phá Fukuoka nhộn nhịp là thành phố lớn nhất ở Kyushu và lớn thứ sáu của Nhật Bản. Do vị trí địa lý gần với đại lục châu Á, Fukuoka từ lâu đã là thành phố cảng quan trọng và ngày nay vẫn là trung tâm thương mại nhộn nhịp. Phần lớn thành phố đã được tái thiết sau Thế chiến 2 nên Fukuoka ngày nay rất hiện đại, đáng sống với dân số trẻ và đang tiếp tục tăng lên về số lượng. Du khách thường đến đây để mua sắm, giải trí hoặc thưởng thức các món ăn tại những quầy hàng ngay bên bờ biển. Đây cũng là điểm xuất phát thuận tiện nhất để đến Kyushu và Honshu ở phía nam nhờ các tuyến đường sắt, đường bộ và phà.",
                    Picture = "pic_8.jpg",
                },
                new Tour()
                {
                    TourName="Du lịch Mỹ mùa Xuân - Los Angeles - Las Vegas - San Diego",
                    DepartureDate = DateTime.Parse("2020/7/25"),
                    NumberOfDay = 7,
                    StartAddress ="Hà Nội",
                    Price = 33599000,
                    NumSeat = 50,
                    EmptySeat = 35,
                    TourType = false,
                    Describe = "Du lịch Mỹ mùa Xuân hành trình đến với Bờ Tây Hoa Kỳ, nơi tọa lạc của những thành phố giải trí phồn hoa bậc nhất thế giới. Thăm kinh đô điện ảnh Hollywood ở Los Angeles, nơi đi đầu trong lĩnh vực sản xuất phim ảnh và biên tập kỹ xảo ấn tượng. Đặt chân đến Đại Lộ Danh Vọng nơi vinh danh những tên tuổi nổi tiếng trong hàng thập kỷ qua. Trong tour du lịch Mỹ mùa Xuân này, du khách sẽ có những ngày vui chơi quên lối về ở thành phố không ngủ về đêm Las Vegas. Nơi hội tụ của những sòng bạc đắt đỏ, những khu phức hợp giải trí đẳng cấp thế giới. Mùa Xuân là mùa đẹp nhất trong năm, Du Lịch Việt sẽ đưa bạn đến với thành phố San Diego, ngắm trọn vẻ đẹp của thành phố biển xinh đẹp nhất nước Mỹ. Đi tour Mỹ mùa xuân 2020 khám phá Los Angeles, Las Vegas và San Diego sẽ là lựa chọn tuyệt vời dành cho du khách.",
                    Picture = "pic_9.jpg"
                },
                new Tour()
                {
                    TourName="Du lịch Hàn Quốc mùa Đông - Seoul - Đảo Nami - Elysian Ski",
                    DepartureDate = DateTime.Parse("2020/7/10"),
                    NumberOfDay = 4,
                    StartAddress ="Hồ Chí Minh",
                    Price = 12999000,
                    NumSeat = 20,
                    EmptySeat = 10,
                    TourType = false,
                    Describe = "Bạn là fan trung thành của những bộ phim Hàn Quốc? Bạn mong được một lần ghé thăm quốc gia này để chiêm ngưỡng những địa điểm du lịch tuyệt đẹp nhất. Vậy thì tại sao không nhanh tay book vé để đi du lịch Hàn Quốc mùa Đông này và có những trải nghiệm thú vị nhất. Ngay sau đây, Du Lịch Việt sẽ giới thiệu tới các bạn các địa điểm không thể bỏ qua khi đi du lịch tại xứ sở kim chi nhé!",
                    Picture = "pic_10.jpg"
                },
            };
            return tours;
        }

        public static List<Customer> getCustomer()
        {
            List<Customer> customers = new List<Customer>()
            {
                new Customer()
                {
                    CustomerName = "Võ Tuấn Phương",
                    IDCard = "1234567890",
                    Phone = "0987654321",
                    Address = "500 Huỳnh Tấn Phát, Quận 7, TP.Hồ Chí Minh",
                },
                new Customer()
                {
                    CustomerName = "Bùi Đức Thiện",
                    IDCard = "0123456798",
                    Phone = "0987654123",
                    Address = "1 Bùi Đình Túy, Quận Bình Thạnh, TP.Hồ Chí Minh",
                },
                new Customer()
                {
                    CustomerName = "Nguyễn Vĩnh Long Vinh",
                    IDCard = "0123456987",
                    Phone = "0987612345",
                    Address = "5 Bà Thiệu, Quận Thủ Đức,TP.Hồ Chí Minh",
                },
            };
            return customers;
        }

        public static List<Bill> GetBills()
        {
            List<Bill> bills = new List<Bill>()
            {
                new Bill()
                {
                    TourID = 1,
                    CustomerID = 1,
                    DateCreated=DateTime.Now,
                },
                new Bill()
                {
                    TourID = 2,
                    CustomerID = 2,
                    DateCreated=DateTime.Now,
                },
                new Bill()
                {
                    TourID = 3,
                    CustomerID = 3,
                    DateCreated=DateTime.Now,
                },
            };
            return bills;
        }

        public static List<Account> getAccounts()
        {
            List<Account> account = new List<Account>()
            {
                new Account()
                {
                    CustomerID = 1,
                    ID = "phuong99",
                    Password="123",
                },

                new Account()
                {
                    CustomerID = 2,
                    ID = "thien99",
                    Password="123",
                },

                new Account()
                {
                    CustomerID = 3,
                    ID = "vinh1999",
                    Password="123",
                },
            };
            return account;
        }

        public static List<Feedback> GetFeedbacks()
        {
            List<Feedback> feedbacks = new List<Feedback>()
            {
                new Feedback()
                {
                    DateCreated = DateTime.Now,
                    Title = "Phản hồi tour 1",
                    Content = "Hỏi về xe đi ?",
                    CustomerID = 1,
                },

                new Feedback()
                {
                    DateCreated = DateTime.Now,
                    Title = "Phản hồi tour 2",
                    Content = "Hỏi về giờ đi ?",
                      CustomerID  = 2,
                },

                new Feedback()
                {
                    DateCreated = DateTime.Now,
                    Title = "Phản hồi tour 3",
                    Content = "Hỏi về số liên hệ ?",
                    CustomerID = 3,
                },
            };
            return feedbacks;
        }
    }
}
