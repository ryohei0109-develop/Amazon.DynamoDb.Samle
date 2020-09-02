using System;
using Amazon.DynamoDb.Sample.Services;
using Amazon.DynamoDBv2;
using Amazon.DynamoDBv2.DocumentModel;

namespace Amazon.DynamoDb.Sample
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"Start. {DateTime.Now.ToString()}");

            using (AmazonDynamoDBClient client = new AmazonDynamoDBClient(
                AccessKey, SecretKey, EndPoint))
            {
                SampleService sampleService = new SampleService();

                string tableName = "TestTable";
                string sku = "test001";

                // テーブルを新規作成します。
                // sampleService.CreateTable(client, tableName);

                // テーブル名のリストを取得します。
                // sampleService.ListTable(client);

                Table table = Table.LoadTable(client, tableName);

                // 1項目を作成・更新します。
                // sampleService.PutItem(client, tableName, sku); // client ver
                // sampleService.PutItem(table, sku);   // table ver

                // 1項目を取得します。
                // sampleService.GetItem(client, tableName, sku);  // client ver
                // sampleService.GetItem(table, sku);  //  table ver

                // 複数個の項目を取得します。
                // sampleService.BatchGetItem(client, tableName); // client ver

                // 複複数項目の作成・更新・削除を行います。
                // sampleService.BatchWriteITem(client, tableName);

                // Queryを使用し、項目を取得します。
                // sampleService.Query(client, tableName);    // client ver
                // sampleService.Query(table);    // table ver

                // 1項目を削除します。
                // sampleService.DeleteItem(client, tableName, sku); // client ver
                // sampleService.DeleteItem(table, sku);   // table ver

                // テーブルを削除します。
                // sampleService.DeleteTable(client, tableName);
            }

            Console.WriteLine($"End. {DateTime.Now.ToString()}");
            Console.ReadLine();
        }

        // ご自身の環境のキーを設定して下さい。
        private const string AccessKey = "";
        private const string SecretKey = "";
        private static readonly RegionEndpoint EndPoint = null;
    }
}
