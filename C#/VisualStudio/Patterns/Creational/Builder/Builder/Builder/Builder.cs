namespace Builder
{
    public interface IBuilder
    {
        void BuildKitchen();

        void BuildLivingRoom();

        void BuildBathRoom();

        void BuildBedRoom();

        void BuildToilet();
    }

    public class Builder : IBuilder
    {
        private Home home;

        public Builder()
        {
            this.Reset();
        }

        public void Reset()
        {
            this.home = new Home();
        }

        public void BuildKitchen()
        {
            this.home.Add("Kitchen");
        }

        public void BuildLivingRoom()
        {
            this.home.Add("LivingRoom");
        }

        public void BuildBathRoom()
        {
            this.home.Add("BathRoom");
        }

        public void BuildBedRoom()
        {
            this.home.Add("BedRoom");
        }

        public void BuildToilet()
        {
            this.home.Add("Toilet");
        }

        public Home GetHome()
        {
            Home result = this.home;

            this.Reset();

            return result;
        }
    }

    public class Director
    {
        private IBuilder builder;

        public IBuilder Builder
        {
            set => builder = value;
        }

        public void BuildMinimal()
        {
            this.builder.BuildBedRoom();
            this.builder.BuildBathRoom();
            this.builder.BuildToilet();
        }

        public void BuildMaximal()
        {
            this.builder.BuildLivingRoom();
            this.builder.BuildBathRoom();
            this.builder.BuildToilet();
            this.builder.BuildKitchen();
            this.builder.BuildBedRoom();
        }
    }
}