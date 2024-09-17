using MauiPlanets.Models;


namespace MauiPlanets.Services
{
    internal class PlanetsService
    {
        private static List<Planet> planets = new()
        {
            new()
            {
                Name = "Mercury",
                Subtitle = "The smallest planet",
                HeroImage = "mercury.png",
                Description = "Mercury is the first planet from the Sun and the smallest in the Solar System. In English, it is named after the ancient Roman god Mercurius (Mercury), god of commerce and communication, and the messenger of the gods. ",
                AccentColorStart = Color.FromArgb("#353535"),
                AccentColorEnd = Color.FromArgb("#8d9098"),
                Images = new()
                {
                    "https://cdn.theatlantic.com/thumbor/D15rQggf6357X1-u6VpTD2N1yQE=/0x27:1041x613/976x549/media/img/mt/2017/04/MercuryImage/original.jpg",
                    "https://www.cronodon.com/images/mercury-5.jpg",
                    "https://science.nasa.gov/_ipx/w_2048&f_webp/https://smd-cms.nasa.gov/wp-content/uploads/2023/05/pia19422-mercury.jpg"
                }
            },
            new()
            {
                Name = "Venus",
                Subtitle = "The pressure cooker",
                HeroImage = "venus.png",
                Description = "Of all the planets, Venus is the one most similar to Earth. In fact, Venus is often called Earth's “sister” planet. As similar as it is in some ways, however, it is also very different in others. ",
                AccentColorStart = Color.FromArgb("#a6393b"),
                AccentColorEnd = Color.FromArgb("#d17f21"),
                Images = new()
                {
                    "https://scx2.b-cdn.net/gfx/news/hires/2022/the-secret-of-venus-ma.jpg",
                    "https://cdn.mos.cms.futurecdn.net/RifjtkFLBEFgzkZqWEh69P-1200-80.jpg",
                    "https://blogger.googleusercontent.com/img/b/R29vZ2xl/AVvXsEg-NrFGofVI6af6bX_z4HvDQatVmHoi8RSirRTvV1pb1K6_tK0VutSmy5Z6NAAcHKFRHBSbGTGne-p31C60bF159Ea1T7A1ozYAgp7GgReE2bk5-FiWuT0BAlk36oE6TPg6Gaq7Ok2_sFMvfDaJaSB_0ESqJwWOEJC0GeX2F93cgu7jG-8-nqX5LJ93oK3h/s1200/illustration-of-surface-of-venus-royalty-free-illustration-1690246003.jpg",
                }
            },
            new()
            {
                Name = "Earth",
                Subtitle = "The cradle of life",
                HeroImage = "earth.png",
                Description = "The Earth is the only planet known where life exists. Almost 1.5 million species of animals and plants have been discovered so far, and many more have yet to be found. While other planets may have small amounts of ice or steam, the Earth is 2/3 water. Earth has perfect conditions for a breathable atmosphere. ",
                AccentColorStart = Color.FromArgb("#0e3d68"),
                AccentColorEnd = Color.FromArgb("#2e97c7"),
                Images = new()
                {
                    "https://images.newscientist.com/wp-content/uploads/2019/09/09162708/iss048-e-2035_lrg.jpg?width=778",
                    "https://s3.amazonaws.com/cms.ipressroom.com/173/files/20233/6436fb312cfac278e61b35e3_Earth/Earth_hero.jpg"
                }
            },
            new()
            {
                Name = "Mars",
                Subtitle = "The red beauty",
                HeroImage = "mars.png",
                Description = "No planet has sparked the imaginations of humans as much " +
                "as Mars. It may be the reddish color of Mars, or the fact that it can " +
                "often be easily seen in the night sky, that has caused people to wonder " +
                "about this close neighbor of ours. Tales of “Martians” invading Earth " +
                "have been around for well over fifty years. But is it likely that any " +
                "kind of life really does exist on Mars? ",
                AccentColorStart = Color.FromArgb("#a23036"),
                AccentColorEnd = Color.FromArgb("#eb3333"),
                Images = new()
                {
                    "https://www.worldatlas.com/r/w1300-q80/upload/bb/c3/32/shutterstock-1041249343.jpg",
                    "https://www.openaccessgovernment.org/wp-content/uploads/2021/04/dreamstime_xxl_121672573-scaled.jpg",
                    "https://researchfdi.com/wp-content/uploads/2021/10/8944_1-PIA24546-1280.jpeg"
                }
            },

            new()
            {
                Name = "Jupiter",
                Subtitle = "The gas giant",
                HeroImage = "jupiter.png",
                Description = "Jupiter is the fifth planet from the Sun and the " +
                "largest in the Solar System. It is a gas giant with a mass more " +
                "than 2.5 times that of all the other planets in the Solar System " +
                "combined, and slightly less than one-thousandth the mass of the " +
                "Sun. Its diameter is eleven times that of Earth, and a tenth " +
                "that of the Sun. ",
                AccentColorStart = Color.FromArgb("#9d4a40"),
                AccentColorEnd = Color.FromArgb("#cd8026"),
                Images = new()
                {
                    "https://scitechdaily.com/images/Deep-Jet-Streams-in-Jupiters-Atmosphere.jpg",
                    "https://orbitaltoday.com/wp-content/uploads/2023/07/Jupiter-rings-1.jpg",
                    "https://as1.ftcdn.net/v2/jpg/01/08/89/18/1000_F_108891862_Cvtc2wppIZ7JXnzPIQoJV34xLmgGkJfm.jpg"
                }
            },

            new()
            {
                Name = "Saturn",
                Subtitle = "The ring planet",
                HeroImage = "saturn.png",
                Description = "Saturn is the sixth planet from the Sun and " +
                            "the second-largest in the Solar System, after " +
                            "Jupiter. It is a gas giant with an average " +
                            "radius of about nine and a half times that " +
                            "of Earth. It has only one-eighth the average " +
                            "density of Earth, but is over 95 times more massive.",
                AccentColorStart = Color.FromArgb("#996237"),
                AccentColorEnd = Color.FromArgb("#c6502f"),
                Images = new()
                {
                    "https://scitechdaily.com/images/Saturns-Appearance-Explained.jpg",
                    "https://planetary.s3.amazonaws.com/image/PIA08361.jpg",
                    "https://www.universetoday.com/wp-content/uploads/2009/12/saturn20131017-e1438109547362.jpg"
                }
            },

            new()
            {
                Name = "Uranus",
                Subtitle = "The Herschel planet",
                HeroImage = "uranus.png",
                Description = "Uranus is the seventh planet from the Sun. " +
                            "It is named after Greek sky deity Uranus (Caelus), who in " +
                            "Greek mythology is the father of Cronus (Saturn), a grandfather " +
                            "of Zeus (Jupiter) and great-grandfather of Ares (Mars). Uranus " +
                            "has the third-largest planetary radius and fourth-largest " +
                            "planetary mass in the Solar System.",
                AccentColorStart = Color.FromArgb("#9d4a40"),
                AccentColorEnd = Color.FromArgb("#996237"),
                Images = new()
                {
                    "https://specials-images.forbesimg.com/imageserve/6001ebfb5977dc0cf4c54471/960x0.jpg?fit=scale",
                    "https://cdn.esawebb.org/archives/images/screen/weic2332a.jpg",
                    "https://static01.nyt.com/images/2023/04/04/multimedia/23sci-uranus-01-vftp/23sci-uranus-01-vftp-videoSixteenByNine3000.jpg"
                }
            },

                        new()
            {
                Name = "Neptune",
                Subtitle = "The god of the sea",
                HeroImage = "neptune.png",
                Description = "Neptune is the eighth planet from the Sun and " +
                            "the farthest known planet in the Solar System. It is the " +
                            "fourth-largest planet in the Solar System by diameter, the " +
                            "third-most-massive planet, and the densest giant planet. " +
                            "It is 17 times the mass of Earth, and slightly more " +
                            "massive than its near-twin Uranus.",
                AccentColorStart = Color.FromArgb("#0c293d"),
                AccentColorEnd = Color.FromArgb("#26abe0"),
                Images = new()
                {
                    "https://www.skymarvels.com/infopages/images/Neptune%20Surface%20-%20SkyMarvels.jpg",
                    "https://mediaproxy.salon.com/width/1200/https://media.salon.com/2023/08/planet_neptune_1365125784.jpg",
                    "https://static.zerochan.net/Planet.Neptune.full.864302.jpg"
                }
            },

            new()
            {
                Name = "Pluto",
                Subtitle = "The distant wanderer",
                HeroImage = "pluto.png",
                Description = "Pluto, a dwarf planet in the distant Kuiper Belt, takes 248 years to orbit the" +
                "Sun. Known for its icy surface and thin atmosphere, it's one of the most remote objects in our" +
                "solar system. Despite its small size, Pluto's fascinating geology was revealed by the New" +
                "Horizons mission in 2015, highlighting its role as the 'Distant Wanderer' of space.",
                AccentColorStart = Color.FromArgb("#9d4a40"),
                AccentColorEnd = Color.FromArgb("#cd8026"),
                Images = new()
                {
                    "https://upload.wikimedia.org/wikipedia/commons/3/30/Pluto.jpg",
                    "https://www.space.com/images/i/000/048/999/original/pluto-new-horizons-july-2015.jpg?interpolation=lanczos-none&fit=inside|660:*"
                }
            },

            new()
            {
                Name = "Ceres",
                Subtitle = "The asteroid queen",
                HeroImage = "ceres.png",
                Description = "Ceres, the largest object in the asteroid belt between Mars and Jupiter, is both" +
                "a dwarf planet and an asteroid. Known for its icy surface and potential for water beneath, it" +
                "makes up a third of the asteroid belt’s mass. As the first asteroid ever discovered, Ceres holds" +
                "a regal status, earning its nickname 'The Asteroid Queen' for its dominance in the region.",
                AccentColorStart = Color.FromArgb("#353535"),
                AccentColorEnd = Color.FromArgb("#8d9098"),
                Images = new()
                {
                    "https://www.space.com/images/i/000/054/070/original/dwarf-planet-ceres-bright-spots-art.jpg?interpolation=lanczos-none&downsize=*:1000",
                    "https://www.nature.com/news/polopoly_fs/7.27294.1434996045!/image/ceres1.jpg_gen/derivatives/landscape_630/ceres1.jpg"
                }
            },

            new()
            {
                Name = "Haumea",
                Subtitle = "The spinning ellipse",
                HeroImage = "haumea.png",
                Description = "Haumea, a dwarf planet in the Kuiper Belt, is known for its rapid rotation and" +
                "elongated, oval shape. It spins so quickly that it completes a rotation every 4 hours, causing" +
                "its unusual shape. Haumea's surface is icy, and it is accompanied by two moons. Its fast spin" +
                "and unique form make it stand out, earning it the nickname 'The Spinning Ellipse.'",
                AccentColorStart = Color.FromArgb("#353535"),
                AccentColorEnd = Color.FromArgb("#8d9098"),
                Images = new()
                {
                    "https://cdnb.artstation.com/p/assets/images/images/005/849/493/large/justinas-vitkus-haumea2.jpg?1494232316",
                    "https://cdn.vox-cdn.com/thumbor/CdERF8KyN81lY4YoQRgfrjIVMW8=/0x0:2040x1360/1200x800/filters:focal(716x450:1042x776)/cdn.vox-cdn.com/uploads/chorus_image/image/57101937/2017_06_07303A_haumea_350_sized.0.jpg"
                }
            },

            new()
            {
                Name = "MakeMake",
                Subtitle = "The remote ruler",
                HeroImage = "makemake.png",
                Description = "Makemake, a dwarf planet in the Kuiper Belt, orbits far from the Sun in one of the" +
                "coldest regions of the solar system. Its surface is icy, with possible traces of methane and" +
                "nitrogen. As one of the largest known objects beyond Neptune, Makemake stands out in its remote" +
                "realm, earning it the title 'The Remote Ruler'.",
                AccentColorStart = Color.FromArgb("#9d4a40"),
                AccentColorEnd = Color.FromArgb("#996237"),
                Images = new()
                {
                    "https://scitechdaily.com/images/artist%E2%80%99s-impression-shows-the-surface-of-the-distant-dwarf-planet-Makemake.jpg",
                    "https://www.universetoday.com/wp-content/uploads/2008/07/Makemake-1280x720.jpg"
                    
                }
            },

            new()
            {
                Name = "Eris",
                Subtitle = "The icy disruptor",
                HeroImage = "eris.png",
                Description = "Eris, one of the most massive dwarf planets in the solar system, resides in the" +
                "distant scattered disk region. Its highly reflective, icy surface and extreme distance from the" +
                "Sun make it one of the coldest known objects. Eris played a key role in the reclassification of" +
                "planets, challenging Pluto's status, which led to the creation of the 'dwarf planet' category." +
                "This disruptive influence and its frozen nature give Eris the fitting nickname 'The Icy Disruptor'.",
                AccentColorStart = Color.FromArgb("#9d4a40"),
                AccentColorEnd = Color.FromArgb("#cd8026"),
                Images = new()
                {
                    "https://www.spaceexploration92.com/wp-content/uploads/2020/01/IMG_20191130_210142-1536x1060.jpg",
                    "https://cdn.eso.org/images/screen/eso1142c.jpg"
                }
            }
        };

        public static List<Planet> GetFeaturedPlanets()
        {
            var random = new Random();
            var randomizePlanets = planets
                .OrderBy(item => random.Next());

            return randomizePlanets
                .Take(2)
                .ToList();
        }

        public static List<Planet> GetAllPlanets()
            => planets;
    }
}
