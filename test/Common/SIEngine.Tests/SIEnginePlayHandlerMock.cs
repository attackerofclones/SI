﻿using SIEngine.Rules;
using SIPackages;

namespace SIEngine.Tests;

internal class SIEnginePlayHandlerMock : ISIEnginePlayHandler
{
    public Action<int, int>? SelectQuestion;

    public void AskForQuestionSelection(IReadOnlyCollection<(int, int)> options, Action<int, int> selectCallback)
    {
        SelectQuestion = selectCallback;
    }

    public void AskForThemeDelete(Action<int> deleteCallback)
    {
        
    }

    public void CancelQuestionSelection()
    {
        
    }

    public void OnFinalThemes(IReadOnlyList<Theme> themes, bool willPlayAllThemes, bool isFirstPlay)
    {
        
    }

    public void OnQuestion(Question question)
    {
        
    }

    public void OnQuestionRestored(int themeIndex, int questionIndex, int price)
    {
        
    }

    public void OnQuestionSelected(int themeIndex, int questionIndex)
    {
        
    }

    public void OnRound(Round round, QuestionSelectionStrategyType strategyType)
    {
        
    }

    public void OnRoundThemes(IReadOnlyList<Theme> themes, IRoundTableController tableController)
    {
        
    }

    public void OnTheme(Theme theme)
    {
        
    }

    public void OnThemeDeleted(int themeIndex)
    {
        
    }

    public void OnThemeSelected(int themeIndex)
    {
        
    }

    public bool ShouldPlayQuestionForAll()
    {
        return true;
    }
}
