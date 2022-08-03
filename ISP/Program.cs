
using ISP.WithoutSOLID;
using ISP.WithSOLID;

//ICarWithoutSOLID jeepWithoutSOLID=new JeepWithoutSOLID();

//jeepWithoutSOLID.Start();

//jeepWithoutSOLID.Drive();

//jeepWithoutSOLID.StartAIAssistant();


ICarWithSOLID jeep = new JeepWithSOLID();

jeep.Start();
jeep.Drive();


IAICarWithSOLID tesla = new TeslaWithSOLID();

tesla.Start();
tesla.Drive();
tesla.StartAIAssistant();

Console.ReadKey();
