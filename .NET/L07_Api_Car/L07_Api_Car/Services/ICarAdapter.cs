using L07_Api_Car.Models;
using L07_Api_Car.Models.Dto;

namespace L07_Api_Car.Services
{
    public interface ICarAdapter
    {
        GetCarResult Bind(Car car);

        Car Bind(PostCarRequest car);

        Car Bind(PutCarRequest car);
    }
}