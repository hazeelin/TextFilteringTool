using TextFilteringTool.Interfaces;

namespace TextFilteringTool.Filters
{
    public abstract class BaseFilter : IHandler
    {
        private IHandler _nextHandler;

        public IHandler SetNext(IHandler handler)
        {
            this._nextHandler = handler;

            return handler;
        }

        public virtual string ApplyFilter(string input)
        {
            if (this._nextHandler != null)
            {
                return this._nextHandler.ApplyFilter(input);
            }
            else
            {
                return input;
            }
        }

        public virtual string Filter(string input)
        {
            //do some processing
            return null;
        }

        public virtual string Filter(string input, string stringValueForRules)
        {
            //do some processing
            return null;
        }

        public virtual string Filter(string input, int intValueForRules)
        {
            //do some processing
            return null;
        }
    }
}
