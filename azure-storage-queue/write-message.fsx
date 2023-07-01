#r "nuget: Azure.Storage.Queues"
open Azure.Storage.Queues
open System
open System.Text
open System.IO

printfn "write-message.fsx"

let connectionString = File.ReadAllText "connection_string.txt"

printfn "connectionString: %s" connectionString

let queueClient = QueueClient(connectionString, "myqueue") 

queueClient.CreateIfNotExists()

let resp = queueClient.SendMessage("Hello, World") // Insert a String message into a queue

printfn "%s" resp.Value.MessageId
