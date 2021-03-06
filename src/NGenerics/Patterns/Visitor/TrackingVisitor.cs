/*  
  Copyright 2007-2017 The NGenerics Team
 (https://github.com/ngenerics/ngenerics/wiki/Team)

 This program is licensed under the MIT License.  You should 
 have received a copy of the license along with the source code.  If not, an online copy
 of the license can be found at https://opensource.org/licenses/MIT.
*/



using System.Collections.Generic;

namespace NGenerics.Patterns.Visitor
{
    /// <summary>
    /// A visitor that tracks (stores) objects in the order they were visited.
    /// Handy for demonstrating and testing different ordered visits implementations on
    /// data structures.
    /// </summary>
    /// <typeparam name="T">The type of objects to be visited.</typeparam>
    public class TrackingVisitor<T> : IVisitor<T>
    {
        #region Globals

        private readonly List<T> _tracks;

        #endregion

        #region Construction


        /// <inheritdoc/>
        public TrackingVisitor()
        {
            _tracks = new List<T>();
        }

        #endregion		

        #region IVisitor<T> Members

        /// <inheritdoc />
        public void Visit(T obj)
        {
            _tracks.Add(obj);
        }

        /// <inheritdoc />
        public bool HasCompleted => false;

        #endregion

        #region Public Members 

        /// <summary>
        /// Gets the tracking list.
        /// </summary>
        /// <value>The tracking list.</value>        
        public IList<T> TrackingList => _tracks;

        #endregion
    }
}