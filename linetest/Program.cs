// See https://aka.ms/new-console-template for more information
var  ChannelAccessToken = "A7sLBq1wo2NWGs/3QpdxwU+xPjOUCa1rDv/pD5A++0VN70eDaE7uxDfQs8+X6ovO1xhFnsrLlivxuBaCaI4MYtG/dnpsCyRVIDcwC98yiZ8GhgzPqWEKZXLrCSNYWgGZ9ooXmtVYSrFjwICh7vz/bwdB04t89/1O/w1cDnyilFU=="; //Channel Access Token
var  UserId = "U984a345566e26f85ba94a560f42d2670"; //收訊者
var  bot = new  isRock.LineBot.Bot(ChannelAccessToken);

// //建立Actions
// var Actions = new List<isRock.LineBot.TemplateActionBase>();
// Actions.Add(new isRock.LineBot.MessageAction() //MessageAction
// {
//     label = "標題-文字回覆",
//     text = "文字回覆"
// });
// Actions.Add(new isRock.LineBot.UriAction() //UriAction
// {
//     label = "標題-開瀏覽器",
//     uri = new Uri("https://www.google.com")
// });
// Actions.Add(new isRock.LineBot.PostbackAction() //PostbackAction
// {
//     label = "標題-按了沒反應?(postback)",
//     data = "abc=aaa&def=111"
// });
// //建立發送訊息
// isRock.LineBot.ButtonsTemplate btnMsg =
// new isRock.LineBot.ButtonsTemplate()
// {
//     thumbnailImageUrl = new Uri("https://i.imgur.com/5JKErL4.png"),
//     text = "ButtonsTempalte的文字",
//     title = "ButtonsTempalte的標題",
//     actions = Actions,
// };
// //發送訊息
// bot.PushMessage(UserId, btnMsg);

// //建立Actions
// Actions = new List<isRock.LineBot.TemplateActionBase>();
// Actions.Add(new isRock.LineBot.MessageAction() //MessageAction
// {
//     label = "Yes",
//     text = "Yes"
// });
// Actions.Add(new isRock.LineBot.MessageAction() //MessageAction
// {
//     label = "No",
//     text = "No"
// });
 
// //建立發送訊息
// isRock.LineBot.ConfirmTemplate ConfirmTemplateMsg =
// new isRock.LineBot.ConfirmTemplate()
// {
//     text = "Confirm Template Message",
//     actions = Actions,
// };
// //發送訊息
// bot.PushMessage(UserId, ConfirmTemplateMsg);

//建立actions
var actions = new List<isRock.LineBot.TemplateActionBase>();
actions.Add(new isRock.LineBot.MessageAction() { label = "標題-文字回覆", text = "回覆文字" });
actions.Add(new isRock.LineBot.UriAction() { label = "標題-Google", uri = new Uri("http://www.google.com") });
actions.Add(new isRock.LineBot.PostbackAction() { label = "標題-發生postback", data = "abc=aaa&def=111" });
//單一Column 
var Column = new isRock.LineBot.Column
{
    text = "ButtonsTemplate文字訊息",
    title = "ButtonsTemplate標題",
    //設定圖片
    thumbnailImageUrl = new Uri("https://i.imgur.com/5JKErL4.png"),
    actions = actions //設定回覆動作
};
//建立CarouselTemplate
var CarouselTemplate = new isRock.LineBot.CarouselTemplate();
//這是範例，所以用一組樣板建立三個
CarouselTemplate.columns.Add(Column);
CarouselTemplate.columns.Add(Column);
CarouselTemplate.columns.Add(Column);
//發送訊息
bot.PushMessage(UserId, CarouselTemplate);