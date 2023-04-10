using Microsoft.AspNetCore.Mvc;

namespace Fit_MI.Controllers;

[ApiController]
[Route("[controller]")]
public class FitMI : ControllerBase
{
   

    private readonly ILogger<FitMIController> _logger;

    public FitMIController(ILogger<FitMIController> logger)
    {
        _logger = logger;
    }

    
    [HttpGet]
    public GetSize(int SuppliedShoeSize,string SuppliedUserLocation)
    {
       if(SuppliedShoeSize !=0 && SuppliedShoeSize != null){

        BaseShoeSize = SuppliedShoeSize;
        
            if(SuppliedUserLocation != null){
            
                switch (SuppliedUserLocation)
                {
                    case Europe:

                    BaseShoeSizeEU = BaseShoeSize * 15.5;
                    break;

                    case North America:
                    BaseShoeSizeNA = BaseShoeSize * 0.5;
                    break;

                    case South America:

                    if( BaseShoeSize > 3 && BaseShoeSize < 12.5){

                        BaseShoeSizeSA = BaseShoeSize * 2.78;
                    }
                    break;

                    case United Kingdom:

                    BaseShoeSizeUK = BaseShoeSize;
                    break;

                    case South Africa:

                    BaseShoeSizeUK = BaseShoeSize;
                    break;

                    case China:

                    BaseShoeSizeCH = BaseShoeSize;
                    break;

                    case Japan:

                    BaseShoeSizeJP = BaseShoeSize;
                    break;

                    case Korea:

                    BaseShoeSizeKR = BaseShoeSize;
                    break;

                    case Australia:

                    BaseShoeSizeAu = BaseShoeSize;
                    break;
                    default:
                }

            }
       }
    }
    [HttpGet]
    public GetCurrentLocation(){
    //Get current location of user
        
    }
    [HttpPost]
    public ConvertToEUSize(){
    //European Shoe Size

    }
    [HttpPost]
    public ConvertToNASize(){
    //North American (US & Canada) Shoe Size
    }

    [HttpPost]
    public ConvertToSASize(){
    //South American (US & Canada) Shoe Size
    }

    [HttpPost]
    public ConvertToUKSize(){
    //United Kingdom and South Africa (US & Canada) Shoe Size
    }
    [HttpPost]
    public ConvertToCHSize(){
    //China Shoe Size
    }
    [HttpPost]
    public ConvertToJPSize(){
    //Japan Shoe Size
    }
    [HttpPost]
    public ConvertToKRSize(){
    //Korean Shoe Size
    }
    [HttpPost]
    public ConvertToAUSize(){
    //Australia Shoe Size
    }
}
