namespace OOP.Interfaces.InterfaceSegregation
{
    public interface IProf : IAssocProf // Profesör --> Bir alt yetki olan Doçent'den kalıtım alıyor.
    {   
        void Dean(); // Dekan
        void Rector(); // Rektör
        void Assigment(); // Atamalar 
    }

}
