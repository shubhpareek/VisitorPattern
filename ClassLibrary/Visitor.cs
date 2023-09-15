namespace ClassLibrary
{
    /// <summary>
    /// Represents a base visitor class for performing operations on different shapes.
    /// </summary>
    public abstract class Visitor
    {
        /// <summary>
        /// Visits a Circle object and performs specific operations on it.
        /// </summary>
        /// <param name="obj">The Circle object to visit.</param>
        public abstract void VisitCircle( Circle obj );

        /// <summary>
        /// Visits a Rectangle object and performs specific operations on it.
        /// </summary>
        /// <param name="obj">The Rectangle object to visit.</param>
        public abstract void VisitRectangle( Rectangle obj );

        /// <summary>
        /// Visits a Triangle object and performs specific operations on it.
        /// </summary>
        /// <param name="obj">The Triangle object to visit.</param>
        public abstract void VisitTriangle( Triangle obj );
    }

}
