
// using static System.Console;

// ///////////////////////

// interface INotificacao
// {
//     void Enviar();
// }

// ///////////////////

// interface IRegistravel

// {
//     void Registrar();
// }   


// class NotificacaoEmail : INotificacao, IRegistravel



// {
//     public void Registrar()
//     {
//         WriteLine("Registrado!");
//     }
//     public void Enviar ()
//     {
//         WriteLine("Notificação enviada por e-mail!");
//     }
// }

// class NotificacaoSMS : INotificacao

// {
//     public void Enviar()
//     {
//         WriteLine("Notificação enviada por SMS!");
//     }
// }


// class NotificacaoWhatsApp : INotificacao

// {
//     public void Enviar()
//     {
//         WriteLine("Notificação enviada pelo WhatsApp!");
//     }
// }

// class Program

// {
//     static void Main()  
//     {
//         INotificacao notificacao1 = new NotificacaoEmail ();        
//         INotificacao notificacao2 = new NotificacaoSMS ();      
//         INotificacao notificacao3 = new NotificacaoWhatsApp ();
//         IRegistravel registro1 = new NotificacaoEmail ();
        
//         WriteLine();        

//         List<IRegistravel> registraveis = new List<IRegistravel>();
//         registraveis.Add(registro1);

//         foreach (IRegistravel registros in registraveis)
//         {
//             registros.Registrar();
//         }

//         List<INotificacao> notificacoes = new List<INotificacao>();
//         notificacoes.Add(notificacao1);
//         notificacoes.Add(notificacao2);
//         notificacoes.Add(notificacao3);

//         foreach (INotificacao notificacao in notificacoes)
//         {
//             notificacao.Enviar();
//         }

//         WriteLine();
//     }   
// }













































































































































































