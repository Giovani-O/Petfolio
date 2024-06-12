using Petfolio.Communication.Responses;

namespace Petfolio.Application.UseCases.Pets.GetById;

public class GetPetByIdUseCase
{
    public ResponsePetJson Execute(int id)
    {
        return new ResponsePetJson { 
            Id = id, 
            Name = "Nano", 
            Type = Communication.Enums.PetType.Cat, 
            Birthday = new DateTime(year: 2011, month: 05, day: 01)
        };
    }
}
