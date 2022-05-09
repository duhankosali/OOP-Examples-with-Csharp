namespace OOP.Interfaces.InterfaceSegregation
{
    public interface IAssocProf : IResearchAssitance // Doçent --> Bir alt yetki olan IResearchAssitance 'den kalıtım alıyor.
    {
        void Proposal(); // Araştırma önerisi vermek
        void HeadOfDeparment(); // Bölüm başkanlığı
    }

}
