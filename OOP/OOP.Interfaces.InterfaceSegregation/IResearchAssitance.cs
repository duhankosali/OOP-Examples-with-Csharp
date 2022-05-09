namespace OOP.Interfaces.InterfaceSegregation
{
    public interface IResearchAssitance : ITeaching // Araştırma Görevlisi --> Bir alt yetki olan ITeaching'den kalıtım alıyor.
    {
        void Researching(); // Araştırma
    }

}
