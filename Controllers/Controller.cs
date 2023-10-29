using Microsoft.AspNetCore.Mvc;
using System;

[ApiController]
[Route("netcon/api/v1/converter")]
public class ConverterController : ControllerBase
{
     private const double AnoLuzToKm = 9.461e12;

    [HttpGet("km")]
    public IActionResult ConvertToKilometers(float anosLuz)
    {
        if (anosLuz < 1)
        {
            return BadRequest(new ConversionResponse
            {
                StatusCode = 400,
                ErrorMessage = "Valor invalido",
                DateTime = DateTime.Now,
                Value = 0
            });
        }

        double kmValue = anosLuz * AnoLuzToKm;

        var response = new ConversionResponse
        {
            StatusCode = 200,
            ErrorMessage = null,
            DateTime = DateTime.Now,
            Value = (float)kmValue
        };

        return Ok(response);
    }

    [HttpGet("anos-luz")]
    public IActionResult ConvertToAnosLuz(float km)
    {
        if (km < 1)
        {
            return BadRequest(new ConversionResponse
            {
                StatusCode = 400,
                ErrorMessage = "Valor invalido",
                DateTime = DateTime.Now,
                Value = 0
            });
        }

        double anosLuzValue = km / AnoLuzToKm;

        var response = new ConversionResponse
        {
            StatusCode = 200,
            ErrorMessage = null,
            DateTime = DateTime.Now,
            Value = (float)anosLuzValue
        };

        return Ok(response);
    }
}
