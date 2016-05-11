using System;

namespace DesignPatterns.Factory
{
    internal class FruitCreator
    {
        private readonly DateTime _moment;

        public FruitCreator()
            : this(DateTime.Now)
        {
        }

        internal FruitCreator(DateTime moment)
        {
            _moment = moment;
        }

        public IFruit CreateFruitForSeason()
        {
            if (_moment.Month <= 3)
            {
                return new Pineapple();
            }

            if (_moment.Month <= 6)
            {
                return new Banana();
            }

            if (_moment.Month <= 9)
            {
                return new Strawberry();
            }

            return new Apple();
        }
    }
}