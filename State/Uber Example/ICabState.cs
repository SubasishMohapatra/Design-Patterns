namespace State
{
    public interface ICabState
    {
        void Book(UberCab cab);
        void StartTrip(UberCab cab);
        void Cancelled(UberCab cab);
        void RideComplete(UberCab cab);
    }
}