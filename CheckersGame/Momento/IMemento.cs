
using System;

namespace CheckersGame
{
    // Создатель содержит некоторое важное состояние, которое может со временем
    // меняться. Он также объявляет метод сохранения состояния внутри снимка и
    // метод восстановления состояния из него.
    //class Originator
    //{
    //    // Для удобства состояние создателя хранится внутри одной переменной.
    //    private int[,] _state;

    //    public Originator(string state)
    //    {
    //        this._state = state;
    //        Console.WriteLine("Originator: My initial state is: " + state);
    //    }

    //    // Бизнес-логика Создателя может повлиять на его внутреннее состояние.
    //    // Поэтому клиент должен выполнить резервное копирование состояния с
    //    // помощью метода save перед запуском методов бизнес-логики.
    //    public void DoSomething()
    //    {
    //        Console.WriteLine("Originator: I'm doing something important.");
    //        this._state = new int[5, 5];// this.GenerateRandomString(30);
    //        Console.WriteLine($"Originator: and my state has changed to: {_state}");
    //    }

    //    private string GenerateRandomString(int length = 10)
    //    {
    //        string allowedSymbols = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ";
    //        string result = string.Empty;

    //        while (length > 0)
    //        {
    //            result += allowedSymbols[new Random().Next(0, allowedSymbols.Length)];

    //            Thread.Sleep(12);

    //            length--;
    //        }

    //        return result;
    //    }

    //    // Сохраняет текущее состояние внутри снимка.
    //    public IMemento Save()
    //    {
    //        return new ConcreteMemento(this._state);
    //    }

    //    // Восстанавливает состояние Создателя из объекта снимка.
    //    public void Restore(IMemento memento)
    //    {
    //        if (!(memento is ConcreteMemento))
    //        {
    //            throw new Exception("Unknown memento class " + memento.ToString());
    //        }

    //        this._state = memento.GetState();
    //        Console.Write($"Originator: My state has changed to: {_state}");
    //    }
    //}

    // Интерфейс Снимка предоставляет способ извлечения метаданных снимка, таких
    // как дата создания или название. Однако он не раскрывает состояние
    // Создателя.
    public interface IMemento<T> where T : ISnapshot
    {
        string Name { get; }

        T GetState();
        DateTime GetDate();
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
