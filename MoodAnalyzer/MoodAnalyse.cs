using System;

/// <summary>
/// MoodAanalyse Class To Check The Mood And Respond.
/// </summary>
public class MoodAnalyse
{
    /// <summary>
    /// AnalyseMood Function To Check The Mood And Respond HAPPY or SAD.
    /// </summary>
    /// <param name="message"></param>
    /// <returns></returns>
    public string AnalyseMood(string message)
    {
        if (message.Contains("Sad"))
        {
            return "SAD";
        }
        else
        {
            return "HAPPY";
        }
    }
}
