using System.Collections.Generic;
using System.Linq;

namespace CommonErrors.Shared
{

    public class AnswerQueue<T> : Queue<T> where T : IGradable
    {
        private readonly int _size;

        public decimal Grade { get { return !this.Any() ? 0 : this.Average(x => x.Grade); } }

        /// <inheritdoc />
        /// <summary>
        /// Stack that cannot exceed it's size
        /// </summary>
        /// <param name="size">Maximum size of the queue</param>
        public AnswerQueue(int size) => _size = size;

        /// <summary>
        /// Hides the default implementation of queue Enqueue 
        /// </summary>
        /// <param name="item"></param>
        public new void Enqueue(T item)
        {
            if (Count >= _size)
            {
                Dequeue();
            }

            base.Enqueue(item);
        }



    }
}
