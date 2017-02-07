using System;
using System.Threading.Tasks;

using Microsoft.Bot.Builder.Azure;
using Microsoft.Bot.Builder.Dialogs;
using Microsoft.Bot.Builder.Luis;
using Microsoft.Bot.Builder.Luis.Models;


using System.Collections.Generic;
using System.Linq;
using System.Web;

// For more information about this template visit http://aka.ms/azurebots-csharp-luis
[Serializable]
public class BasicLuisDialog : LuisDialog<object>
{
    public BasicLuisDialog() : base(new LuisService(new LuisModelAttribute(Utils.GetAppSetting("LuisAppId"), Utils.GetAppSetting("LuisAPIKey"))))
    {
    }

    [LuisIntent("None")]
    public async Task NoneIntent(IDialogContext context, LuisResult result)
    {
        await context.PostAsync($"Please stop wasting time. "); //
        context.Wait(MessageReceived);
    }

    // Go to https://luis.ai and create a new intent, then train/publish your luis app.
    // Finally replace "MyIntent" with the name of your newly created intent in the following handler
    
    
    [LuisIntent("greetings")]
    public async Task greetingIntent(IDialogContext context, LuisResult result)
    {
        await context.PostAsync($"Hello there..."); //
        context.Wait(MessageReceived);
    }
    
    [LuisIntent("greetingstate")]
    public async Task greetingstateIntent(IDialogContext context, LuisResult result)
    {
        await context.PostAsync($"Everything is going fine. How may I be use ful to you. If Help required feel free to ask."); //
        context.Wait(MessageReceived);
    }
    
    [LuisIntent("Offer")]
    public async Task offerIntent(IDialogContext context, LuisResult result)
    {
        await context.PostAsync($"Welcome to the offer section. Please reply as cashback or discounts or Wholesale offers."); //
        context.Wait(MessageReceived);
    }
    
    [LuisIntent("cashbackoffer")]
    public async Task cashbackofferIntent(IDialogContext context, LuisResult result)
    {
        await context.PostAsync($"Welcome to the cash back offer section. Some available offers are..");
        await context.PostAsync($"10% cashback on buying 2 premium seat covers, by Carmodifiers.(for more info, visit: Carmodifiers.com) ");
        await context.PostAsync($"15% cashback on buying 3 printed shirts, by Faishon designers. (for more info, visit: Faishodesigners.com) ");
         await context.PostAsync($"5% cashback on buying 2 Adidas shoes, by Shoeshoppers. (for more info, visit: Shoeshoppers.com)");
         await context.PostAsync($"20% cashback on buying 6 sarees, by SareeAdda. (for more info, visit: SareeAdda.com)");
        
        
        context.Wait(MessageReceived);
    }
    
    [LuisIntent("discountoffer")]
    public async Task discountofferIntent(IDialogContext context, LuisResult result)
    {
        await context.PostAsync($"Welcome to the discount offer section. The available discount offers are.... ");
        await context.PostAsync($"upto 30% discounts on chinese crockey set, by Crockerystore. (for more info, visit: Crockerystore.com) ");
        await context.PostAsync($"upto 40% discounts on Mens clothings & upto 20% discounts on kids clothings, by Familyclothing. (for more info, visit: Familyclothing.com)  ");
        await context.PostAsync($"upto 10% discounts on sports equipments, by KhoobKhelo.  (for more info, visit: KhoobKhelo.com) ");
        await context.PostAsync($"upto 4.2% discount on new Honda bikes, by bikerspot. (for more info, visit: bikerspot.com)");
        await context.PostAsync($"upto 33% discount on makeup equipments and accessories, by Forher. (for more info, visit: Forher.com) ");
        
        
        context.Wait(MessageReceived);
    }
    
    [LuisIntent("wholesale")]
    public async Task wholesaleofferIntent(IDialogContext context, LuisResult result)
    {
        await context.PostAsync($"Welcome to the wholesale offer section. The available wholesale offers are.... ");
        await context.PostAsync($"Buy 4 sarees get 2 free, by Sareeadda.");
        await context.PostAsync($"Buy 3 shirts,get 1 free, by Mensome.");
        await context.PostAsync($"Buy 2 pants, get 1 free, by Mensome.");
        
        context.Wait(MessageReceived);
    }
    
    [LuisIntent("appointments")]
    public async Task appointmentIntent(IDialogContext context, LuisResult result)
    {
        await context.PostAsync($"Welcome to the appointments section.");
        await context.PostAsync($"For Dr. Adarsh go to: adarsh123@something.com");
        await context.PostAsync($"For Dr. Sumeet go to: sumeet123@something.com");
        await context.PostAsync($"For Dr. Naina go to: naina123@something.com");
        
        context.Wait(MessageReceived);
    }
    
    [LuisIntent("Help")]
        public async Task Help(IDialogContext context, LuisResult result)
        {
           await context.PostAsync($"help section");
           await context.PostAsync($"For bookings , reply as booking.");
           await context.PostAsync($"For appointments , reply as appointment");
           await context.PostAsync($"For ordering  , reply as orders.");
           context.Wait(MessageReceived);
        }
        
        
    
    
    
    
    [LuisIntent("bookings")]
    public async Task bookingIntent(IDialogContext context, LuisResult result)
    {
        await context.PostAsync($"Welcome to the bookings section.");
        await context.PostAsync($"For booking Dine table, reply as Dinetable booking.");
        await context.PostAsync($"For booking bowling, reply as bowling booking");
        await context.PostAsync($"For booking Movie Tickets, reply as Ticket booking");

        context.Wait(MessageReceived);
    }
    
    [LuisIntent("thankyou")]
    public async Task thankyouIntent(IDialogContext context, LuisResult result)
    {
        await context.PostAsync($"Ohh.. welcome.");
        
        context.Wait(MessageReceived);
    }
    
    [LuisIntent("dinetable")]
    public async Task dinetableIntent(IDialogContext context, LuisResult result)
    {
        await context.PostAsync($"For booking dinetable at Hotel Grand Dhillon, go to granddhillon.com .");
        await context.PostAsync($"For booking dinetable at Hotel Amit, go to HotelAmit.com .");
        await context.PostAsync($"For booking dinetable at Hotel Sagar, go to HotelSagar.com .");
         await context.PostAsync($"For booking dinetable at Hotel Dinein, go to Dinein.com .");
        context.Wait(MessageReceived);
    }
    
    [LuisIntent("bowlingbooking")]
    public async Task bowlingIntent(IDialogContext context, LuisResult result)
    {
        await context.PostAsync($"For booking for bowling, go to striker.com .");
       
        context.Wait(MessageReceived);
    }
    
    [LuisIntent("mobile")]
    public async Task mobileIntent(IDialogContext context, LuisResult result)
    {
        await context.PostAsync($"For booking movie tickets, go to bookmeticket.com .");
       
        context.Wait(MessageReceived);
    }
   
    
    
    
    
}