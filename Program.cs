using System.Text;

internal class Program
{
    private static void Main(string[] args)
    {
        // StringBuilderインスタンスを生成
        StringBuilder sb = new StringBuilder();

        // 行数を指定
        int lineCnt = 9;

        // 列数を指定
        int rowCnt = 9;


        // メソッド呼び出し
        OutPutConsole(sb, lineCnt, rowCnt);
    }

    // 九九表をコンソールに表示するメソッド
    private static void OutPutConsole(StringBuilder sb, int lineCnt, int columnCnt)
    {
        // 行数分ループ
        for (int i = 1; i <= lineCnt; i++)
        {
            // 列数分ループ
            for (int j = 1; j <= columnCnt; j++)
            {
                // 0埋め2桁で値を格納
                string str = (i * j).ToString("00");
                sb.Append(str);

                // 最後の列以外でなければカンマを追加
                if (j != (columnCnt))
                {
                    sb.Append(",");
                }
            }
            // コンソールに1行表示
            Console.WriteLine(sb);

            // sbに格納された文字列をクリア
            sb.Clear();
        }
    }
}