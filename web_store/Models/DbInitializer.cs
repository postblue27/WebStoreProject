using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace web_store.Models
{
    public static class DbInitializer
    {
        public static void Seed(IServiceProvider serviceProvider)
        {
            using (AppDbContext context = new AppDbContext(
                serviceProvider.GetRequiredService<DbContextOptions<AppDbContext>>()))
            {
                if (!context.Categories.Any())
                {
                    context.Categories.AddRange(Categories.Select(c => c.Value));
                }

                if (!context.Products.Any())
                {
                    context.AddRange
                    (
                        new Product { Name = "Dell Monitor", Price = 122.95M, ShortDescription = "Dell UltraSharp U2312HM 23 IPS LED LCD Monitor", LongDescription = "Lose yourself in the details: : Enjoy 1920x1080 (max) HD resolution, a vivid 2,000,000:1 (typical) dynamic contrast ratio and IPS technology for outstanding color consistency across a wide viewing range Stay comfortable and connected: Select your best view with a range of tilt, swivel, pivot and height options. Link to a range of devices with 4 USB ports, a DisplayPort, plus DVI and VGA connections. Be environmentally-conscious: Beyond offering efficiency and vivid detail, this monitor also meets EPEAT Gold standards and is ENERGY STAR qualified.", Category = Categories["Tech"], ImageUrl = "https://postblue.blob.core.windows.net/img/monitor-1-large.jpg?sp=r&st=2019-10-05T10:16:42Z&se=2022-10-05T18:16:42Z&spr=https&sv=2018-03-28&sig=CiXcOeguqa3ht74uLupcemkAGmXLAJyir%2Fmr2wLU9ro%3D&sr=b", InStock = true, ImageThumbnailUrl = "https://postblue.blob.core.windows.net/img/monitor-1-small.jpg?sp=r&st=2019-10-05T10:16:56Z&se=2022-10-05T18:16:56Z&spr=https&sv=2018-03-28&sig=HHcVpQvYV2U4XTPYFRvhU7D%2FNsQZUty1hLpu4y3PQAc%3D&sr=b" },
                        new Product { Name = "Crime and Punishment", Price = 18.95M, ShortDescription = "Crime and Punishment Paperback – June 12, 2010 by Fyodor Dostoevsky", LongDescription = "Crime and Punishment focuses on the mental anguish and moral dilemmas of Rodion Romanovich Raskolnikov, an impoverished St. Petersburg ex-student who formulates and executes a plan to kill an unscrupulous pawnbroker for her money. Raskolnikov argues that with the pawnbroker's money he can perform good deeds to counterbalance the act, while ridding the world of a worthless parasite. The murder is also committed to test Raskolnikov's hypothesis that some people are naturally able and have the right to murder. Despite his rationale, Raskolnikov struggles with extreme guilt and fear once the act is committed . . .", Category = Categories["Books"], ImageUrl = "https://postblue.blob.core.windows.net/img/book-1-large.jpg?sp=r&st=2019-10-05T10:09:53Z&se=2022-03-01T19:09:53Z&spr=https&sv=2018-03-28&sig=IgmI0juSkTYRlI8TEmKre6v9%2FFougI%2BtP7D%2Bsnw1%2FMU%3D&sr=b", InStock = true, ImageThumbnailUrl = "https://postblue.blob.core.windows.net/img/book-1-small.jpg?sp=r&st=2019-10-05T10:12:13Z&se=2022-10-05T18:12:13Z&spr=https&sv=2018-03-28&sig=h8HNkoBZG366GPZrTcnTR6CsY1pk9o0%2F4%2FR6nndn1uI%3D&sr=b"},
                        new Product { Name = "BenQ Monitor", Price = 139.99M, ShortDescription = "BenQ 24 Inch IPS Monitor | 1080P | Proprietary Eye-Care Tech", LongDescription = "24 inch Full HD 1080P IPS panel: 23. 8” Full HD IPS widescreen with 1920x1080 resolution, 250 nits of brightness, built-in speakers Wide viewing angle: 178° wide viewing angle for Clarity from any viewing angle Edge to edge slim bezel design: ultra-slim bezel for virtually seamless multi-panel configurations for extended view, space-saving base, elegant design for home office Patented Eye-Care for extended use: Proprietary brightness Intelligence Adaptive technology adjusts brightness for comfortable viewing, low Blue light and zeroflicker technology prevent headaches and eye strain. This eye Tech delivers optimized images that are easy on your eyes. Integrated cable management system: neatly hides cables inside monitor stand; VESA wall mount: 100x100 (mm)", Category = Categories["Tech"], ImageUrl = "https://postblue.blob.core.windows.net/img/monitor-2-large.jpg?sp=r&st=2019-10-05T10:17:28Z&se=2022-10-05T18:17:28Z&spr=https&sv=2018-03-28&sig=IpLEV06mhp%2FJMa%2B2%2BelS1f2DO7a5c5ZIPTCMjOc9b6s%3D&sr=b", InStock = true, ImageThumbnailUrl = "https://postblue.blob.core.windows.net/img/monitor-2-small.jpg?sp=r&st=2019-10-05T10:17:41Z&se=2022-10-05T18:17:41Z&spr=https&sv=2018-03-28&sig=U3LjfWlZCzm5gA3dBNH1hvGKiRLz0Qhf7sP7dMxGMr4%3D&sr=b"},
                        new Product { Name = "Acer Monitor", Price = 89.99M, ShortDescription = "Acer SB220Q bi 21.5 Full HD (1920 x 1080) IPS Ultra-Thin Zero Frame Monitor (HDMI & VGA port)", LongDescription = "21. 5 Full HD (1920 x 1080) widescreen IPS display And Radeon free Sync technology. No compatablity for VESA Mount Refresh Rate: 75Hz - Using HDMI port Zero-frame design | ultra-thin | 4ms response time | IPS panel Ports: 1 x HDMI & 1 x VGA Aspect ratio - 16: 9. Color Supported - 16. 7 million colors. Brightness - 250 nit Tilt angle -5 degree to 15 degree. Horizontal viewing angle ? 178 degree. Vertical viewing angle ? 178 degree 75 hertz", Category = Categories["Tech"], ImageUrl = "https://postblue.blob.core.windows.net/img/monitor-3-large.jpg?sp=r&st=2019-10-05T10:17:57Z&se=2022-10-05T18:17:57Z&spr=https&sv=2018-03-28&sig=9Hnog801jIAfaOu83M59VdEif6QmplmMNrSiN0PMlIw%3D&sr=b", InStock = true, ImageThumbnailUrl = "https://postblue.blob.core.windows.net/img/monitor-3-small.jpg?sp=r&st=2019-10-05T10:18:14Z&se=2022-10-05T18:18:14Z&spr=https&sv=2018-03-28&sig=KppSyRKxpDred%2FVGpD3MggfXI57O2cyMUUCXuxr2nDY%3D&sr=b"},
                        new Product { Name = "The Brothers Karamazov", Price = 20.99M, ShortDescription = "The Brothers Karamazov Paperback – June 14, 2002 by Fyodor Dostoevsky", LongDescription = "The Brothers Karamasov is a murder mystery, a courtroom drama, and an exploration of erotic rivalry in a series of triangular love affairs involving the “wicked and sentimental” Fyodor Pavlovich Karamazov and his three sons―the impulsive and sensual Dmitri; the coldly rational Ivan; and the healthy, red-cheeked young novice Alyosha. Through the gripping events of their story, Dostoevsky portrays the whole of Russian life, is social and spiritual striving, in what was both the golden age and a tragic turning point in Russian culture. This award-winning translation by Richard Pevear and Larissa Volokhonsky remains true to the verbal inventiveness of Dostoevsky’s prose, preserving the multiple voices, the humor, and the surprising modernity of the original. It is an achievement worthy of Dostoevsky’s last and greatest novel.", Category = Categories["Books"], ImageUrl = "https://postblue.blob.core.windows.net/img/book-2-large.jpg?sp=r&st=2019-10-05T10:13:20Z&se=2022-10-05T18:13:20Z&spr=https&sv=2018-03-28&sig=MhILYWIuvNVpzFTmNivdo0cA%2Bc6C16fa%2Fy3o1C8nrOA%3D&sr=b", InStock = true, ImageThumbnailUrl = "https://postblue.blob.core.windows.net/img/book-2-small.jpg?sp=r&st=2019-10-05T10:13:36Z&se=2022-10-05T18:13:36Z&spr=https&sv=2018-03-28&sig=sPx%2FZnA3ytb3BEtqYJJVaENWbRqnFIHd51NF4J7%2Fbs8%3D&sr=b"},
                        new Product { Name = "All Quiet on the Western Front", Price = 17.99M, ShortDescription = "All Quiet on the Western Front: A Novel Mass Market Paperback – March 12, 1987 by Erich Maria Remarque", LongDescription = "Considered by many the greatest war novel of all time, All Quiet on the Western Front is Erich Maria Remarque’s masterpiece of the German experience during World War I. I am young, I am twenty years old; yet I know nothing of life but despair, death, fear, and fatuous superficiality cast over an abyss of sorrow. . . . This is the testament of Paul Bäumer, who enlists with his classmates in the German army during World War I. They become soldiers with youthful enthusiasm. But the world of duty, culture, and progress they had been taught breaks in pieces under the first bombardment in the trenches. Through years of vivid horror, Paul holds fast to a single vow: to fight against the principle of hate that meaninglessly pits young men of the same generation but different uniforms against one another . . . if only he can come out of the war alive. “The world has a great writer in Erich Maria Remarque. He is a craftsman of unquestionably first rank, a man who can bend language to his will. Whether he writes of men or of inanimate nature, his touch is sensitive, firm, and sure.”—The New York Times Book Review", Category = Categories["Books"], ImageUrl = "https://postblue.blob.core.windows.net/img/book-3-large.jpg?sp=r&st=2019-10-05T10:14:13Z&se=2022-10-05T18:14:13Z&spr=https&sv=2018-03-28&sig=%2F1UMCMOfmb%2BC8ybV1WSuWG6ks%2F3%2B83PcEHZwyud%2BqqY%3D&sr=b", InStock = true, ImageThumbnailUrl = "https://postblue.blob.core.windows.net/img/book-3-small.jpg?sp=r&st=2019-10-05T10:14:42Z&se=2022-10-05T18:14:42Z&spr=https&sv=2018-03-28&sig=YiL%2BmEWEskIna4Bg8C46gX7IgeYJfIxmepmSpzpmVrg%3D&sr=b"}
                    );
                }

                context.SaveChanges();
            }
        }
                        private static Dictionary<string, Category> categories;
        public static Dictionary<string, Category> Categories
        {
            get
            {
                if (categories == null)
                {
                    var genresList = new Category[]
                    {
                        new Category { CategoryName = "Books" },
                        new Category { CategoryName = "Tech" }
                    };

                    categories = new Dictionary<string, Category>();

                    foreach (Category genre in genresList)
                    {
                        categories.Add(genre.CategoryName, genre);
                    }
                }

                return categories;
            }
        }
    }
}
