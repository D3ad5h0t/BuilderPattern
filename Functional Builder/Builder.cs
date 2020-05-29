using System;
using System.Collections.Generic;
using System.Linq;

namespace Functional_Builder
{
    public class Builder
    {
        
    }
    
    public abstract class FunctoinalBuilder<TSubject, TSelf>
        where TSelf : FunctoinalBuilder<TSubject, TSelf>
        where TSubject : new()
    {
        public readonly List<Func<TSubject, TSubject>> Actions = new List<Func<TSubject, TSubject>>();

        public TSelf Do(Action<TSubject> action) => AddAction(action);

        private TSelf AddAction(Action<TSubject> action)
        {
            Actions.Add(p =>
            {
                action(p);
                return p;
            });

            return (TSelf) this;
        }

        public TSubject Build() => Actions.Aggregate(
            new TSubject(),
            (p, f) => f(p)
        );
    }
}