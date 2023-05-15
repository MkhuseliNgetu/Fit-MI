using Microsoft.AspNetCore.Mvc;

namespace Fit_MI.Controllers;

[ApiController]
[Route("[controller]")]
public class FitMI : ControllerBase
{
   
    private int BaseShoeSizeEU = 0;
    private int BaseShoeSizeNA = 0;
    private int BaseShoeSizeSA = 0;
    private int BaseShoeSizeUK = 0;
    private int BaseShoeSizeZA = 0;
    private int BaseShoeSizeCH = 0;
    private int BaseShoeSizeJP = 0;
    private int BaseShoeSizeKR = 0;
    private int BaseShoeSizeAU = 0;  
    private readonly ILogger<FitMIController> _logger;

    public FitMIController(ILogger<FitMIController> logger)
    {
        _logger = logger;
    }

    [HttpPost]
    public int ConvertToEurope(string MyLocation, int ShoeSize){
        //European Shoe Size
        if(MyLocation.Equals("EU") && ShoeSize >=0){

            int Temp = ShoeSize / 15.5;

            if(Temp >= 15.5 && Temp <= 48.5){

                BaseShoeSizeEU = Temp;
            }else{

                throw new System.Exception("This shoe size does not exist in Europe.");
            }
        } 
        return BaseShoeSizeEU;
    }
    [HttpPost]
    public int ConvertToNorthAmerica(string MyLocation, int ShoeSize){

        //North American (US & Canada) Shoe Size
        if(MyLocation.Equals("NA") && ShoeSize >=0){

            int Temp = ShoeSize / 0.5;

            if(Temp >= 0.5 && Temp <= 15.5){

                BaseShoeSizeNA = Temp;
            }else{

                throw new System.Exception("This shoe size does not exist in North America (United States & Canada).");
            }
        }
        return BaseShoeSizeNA;
    }
    [HttpPost]
    public int ConvertToSouthAmerica(string MyLocation, int ShoeSize){
       
        //South American (Mexico & Brazil) Shoe Size
        if(MyLocation.Equals("SA") && ShoeSize >=0){
           
            int Temp = ShoeSize / 4.5;
            
            if(Temp >= 4.5 && Temp < 12.5){

                BaseShoeSizeSA = Temp;
            }else{

                throw new System.Exception("This shoe size does not exist in South America (Mexico & Brazil).");
            }
        }
        return BaseShoeSizeSA;
    }

    [HttpPost]
    public int ConvertToUnitedKingdom(string MyLocation, int ShoeSize){
        
        //United Kingdom (UK) Shoe Size
        if(MyLocation.Equals("UK") && ShoeSize >=0){

            int Temp = ShoeSize / 0.5;
        
            if(Temp >=0 && Temp <=13){

                  BaseShoeSizeUK = Temp;
            }else{

                throw new System.Exception("This shoe size does not exist in the United Kingdom.");
            }

        }
        return BaseShoeSizeUK;
    }
    [HttpPost]
    public int ConvertToAfrica(string MyLocation, int ShoeSize){
    
        //Africa (South Africa) (ZA) Shoe Size
        if(MyLocation.Equals("AFCA") && ShoeSize >=0){
            
            int Temp = ShoeSize / 0.5;

            if(BaseShoeSizeZA >=0 && BaseShoeSizeZA <=13){

                BaseShoeSizeZA = Temp;
            }else{

                throw new System.Exception("This shoe size does not exist in the South Africa.");
            }

        }
        return  BaseShoeSizeZA;
    }
    [HttpPost]
    public int ConvertToCHSize(string MyLocation, int ShoeSize){
    
        //China Shoe Size
        if(MyLocation.Equals("CH") && ShoeSize >=0){

            int Temp = ShoeSize / 35.5;

            if(Temp >=35 && Temp <=48){
                   
                   BaseShoeSizeCH = Temp;
            }else{

                throw new System.Exception("This shoe size does not exist in the China.");
            }

        }
        return BaseShoeSizeCH;
    }
    [HttpPost]
    public int ConvertToJPSize(string MyLocation, int ShoeSize){
        
        //Japan Shoe Size
        if(MyLocation.Equals("JP") && ShoeSize >=0){

            int Temp = ShoeSize / 21;

            if(BaseShoeSizeJP >=21 && BaseShoeSizeJP <=31.5){

                  BaseShoeSizeJP = Temp;
            }else{

                throw new System.Exception("This shoe size does not exist in the Japan.");
            }

        }
        return BaseShoeSizeJP;
    }
    [HttpPost]
    public int ConvertToKRSize(){
        
         //Korean Shoe Size
         if(MyLocation.Equals("KR") && ShoeSize >=0){
            
            int Temp = ShoeSize / 228;
           
            if(BaseShoeSizeKR >=228 && BaseShoeSizeKR <=292){
                  BaseShoeSizeKR = Temp;
            }else{

                throw new System.Exception("This shoe size does not exist in the Korea.");
            }

        }
        return BaseShoeSizeKR;
    }
    [HttpPost]
    public int ConvertToAUSize(){
    
        //Australia Shoe Size
        if(MyLocation.Equals("AU") && ShoeSize >=0){
            
            int Temp = ShoeSize / 0.5;
            
            if(BaseShoeSizeAU >=0 && BaseShoeSizeAU <=13){
                  
                  BaseShoeSizeAU = Temp;
            }else{

                throw new System.Exception("This shoe size does not exist in the Australia.");
            }

        }
        return BaseShoeSizeAU;
    }
}
