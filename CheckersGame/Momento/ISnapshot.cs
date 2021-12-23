namespace CheckersGame
{
    public interface ISnapshot
    {
    }

    // Опекун не зависит от класса Конкретного Снимка. Таким образом, он не
    // имеет доступа к состоянию создателя, хранящемуся внутри снимка. Он
    // работает со всеми снимками через базовый интерфейс Снимка.
    //class Caretaker
    //{
    //    private List<IMemento> _mementos = new List<IMemento>();

    //    private Originator _originator = null;

    //    public Caretaker(Originator originator)
    //    {
    //        this._originator = originator;
    //    }

    //    public void Backup()
    //    {
    //        Console.WriteLine("\nCaretaker: Saving Originator's state...");
    //        this._mementos.Add(this._originator.Save());
    //    }

    //    public void Undo()
    //    {
    //        if (this._mementos.Count == 0)
    //        {
    //            return;
    //        }

    //        var memento = this._mementos.Last();
    //        this._mementos.Remove(memento);

    //        Console.WriteLine("Caretaker: Restoring state to: " + memento.GetName());

    //        try
    //        {
    //            this._originator.Restore(memento);
    //        }
    //        catch (Exception)
    //        {
    //            this.Undo();
    //        }
    //    }

    //    public void ShowHistory()
    //    {
    //        Console.WriteLine("Caretaker: Here's the list of mementos:");

    //        foreach (var memento in this._mementos)
    //        {
    //            Console.WriteLine(memento.GetName());
    //        }
    //    }
    //}

    //class Program
    //{
    //    static void Main(string[] args)
    //    {
    //        // Клиентский код.
    //        Originator originator = new Originator("Super-duper-super-puper-super.");
    //        Caretaker caretaker = new Caretaker(originator);

    //        caretaker.Backup();
    //        originator.DoSomething();

    //        caretaker.Backup();
    //        originator.DoSomething();

    //        caretaker.Backup();
    //        originator.DoSomething();

    //        Console.WriteLine();
    //        caretaker.ShowHistory();

    //        Console.WriteLine("\nClient: Now, let's rollback!\n");
    //        caretaker.Undo();

    //        Console.WriteLine("\n\nClient: Once more!\n");
    //        caretaker.Undo();

    //        Console.WriteLine();
    //    }
    //}

}
