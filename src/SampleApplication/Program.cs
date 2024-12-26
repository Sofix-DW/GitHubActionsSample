// See https://aka.ms/new-console-template for more information
using SampleApplication;

Console.WriteLine("=== ダイスバトルゲーム ===");

Console.Write("プレイヤー数を入力してください: ");
int playerCount;
while (!int.TryParse(Console.ReadLine(), out playerCount) || playerCount <= 1)
{
    Console.WriteLine("有効なプレイヤー数を入力してください（2以上の整数）:");
}

// プレイヤーリストの作成
var players = PlayerFactory.CreatePlayers(playerCount);

Console.Write("\nラウンド数を入力してください: ");
int totalRounds;
while (!int.TryParse(Console.ReadLine(), out totalRounds) || totalRounds <= 0)
{
    Console.WriteLine("有効なラウンド数を入力してください（1以上の整数）:");
}

Console.WriteLine("\nゲームを開始します！");

// ラウンド管理クラスを作成
var roundManager = new RoundManager(players);

// ラウンドごとのプレイ
for (var round = 1; round <= totalRounds; round++)
{
    Console.WriteLine($"\n--- ラウンド {round} ---");
    roundManager.PlayRound(round);
}

// 最終結果を表示
Console.WriteLine("\n=== 最終結果 ===");

// 総得点で順位を決定
var ranking = players.OrderByDescending(p => p.TotalScore).ToList();
for (var rank = 0; rank < ranking.Count; rank++)
{
    Console.WriteLine($"{rank + 1}位: {ranking[rank].Name} (得点: {ranking[rank].TotalScore})");
}

// 勝者の表示
if (ranking.Count > 1 && ranking[0].TotalScore == ranking[1].TotalScore)
{
    Console.WriteLine("\nトップは引き分けです！");
}
else
{
    Console.WriteLine($"\n優勝: {ranking[0].Name}！!");
}

Console.WriteLine("\nゲーム終了です。お疲れ様でした！");
