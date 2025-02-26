namespace WebApplication1.Models
{
    public interface IRepository
    {
        public Reservation AddReservation(Reservation reservation);
        public Reservation UpdateReservation(Reservation reservation);
        void DeleteReservation(int Id);
        IEnumerable<Reservation> Reservations { get; }
        Reservation this[int id] { get; }
    }
}
