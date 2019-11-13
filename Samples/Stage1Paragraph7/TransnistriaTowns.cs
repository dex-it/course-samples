using System.Collections;

namespace Stage1Paragraph7
{
    class TransnistriaTowns : IEnumerable
    {
        string[] Towns = {"Тирасполь", "Бендеры", "Рыбница", "Каменка", "Дубоссары",
            "Григориополь", "Слободзея", "Днестровск"};

        public IEnumerator GetEnumerator()
        {
            return new TownEnumerator(Towns);
        }
    }
}
