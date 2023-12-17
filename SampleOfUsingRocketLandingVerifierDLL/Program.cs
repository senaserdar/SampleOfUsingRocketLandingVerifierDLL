using RocketLandingVerifier.RocketLandingLibrary;
using RocketLandingVerifier.RocketLandingLibrary.Dto;

class Program
{
    static void Main(string[] args)
    {
        // LandingAreaVerifierInput ile giriş verisini oluşturalım
        LandingAreaVerifierInput input = new LandingAreaVerifierInput
        {
            LandingAreaWidth = 10,
            LandingAreaLength = 10,
            PlatformStartX = 2,
            PlatformStartY = 2,
            PlatformWidth = 4,
            PlatformLength = 4
        };

        // LandingAreaVerifier örneğini oluşturalım
        LandingAreaVerifier verifier = new LandingAreaVerifier(input);

        // Örnek kullanımlar:
        Console.WriteLine(verifier.VerifyLanding(3, 3)); // İniş için uygun
        Console.WriteLine(verifier.VerifyLanding(10, 10)); // Platform dışı
        Console.WriteLine(verifier.VerifyLanding(5, 5)); // İniş için uygun
        Console.WriteLine(verifier.VerifyLanding(5, 5)); // Çarpışma (çünkü zaten işaretlendi)
        Console.ReadLine();
    }
}