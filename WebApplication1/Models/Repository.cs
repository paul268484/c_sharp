namespace WebApplication1.Models
{
    public class Repository : IRepository   
    {
        private Dictionary<int, Reservation> items;
        public Repository()
        {
            items = new Dictionary<int, Reservation>();
            new List<Reservation>
            {
                new Reservation{Id=1,Name="Kadhir",StartLocation="Pune",EndLocation="Chennai"},
                new Reservation{Id=2,Name="Selva",StartLocation="Punjab",EndLocation="Coimbatore"},
                new Reservation{Id=3,Name="Arun",StartLocation="Cochin",EndLocation="Tirupur"},
                new Reservation{Id=4,Name="Kowsi",StartLocation="Tirupur",EndLocation="Bangaluru"}

            }.ForEach(r => AddReservation(r));
        }
        public Reservation this[int id] => items.ContainsKey(id) ? items[id] : null;
        public IEnumerable<Reservation> Reservations => items.Values;


        //IEnumerable<Reservation> IRepository.Reservations => throw new NotImplementedException();

        public Reservation AddReservation(Reservation reservation)
        {
            if (reservation.Id == 0)
            {
                int key = items.Count;
                while (items.ContainsKey(key)) { key++; };
                reservation.Id = key;
            }
            items[reservation.Id] = reservation;
            return reservation;
        }

        void IRepository.DeleteReservation(int id)
        {
            items.Remove(id);
        }

        Reservation IRepository.UpdateReservation(Reservation reservation)
        {
            return AddReservation(reservation);
        }
    }
}
