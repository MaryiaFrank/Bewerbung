package ReadablilityScore;

import java.io.File;
import java.io.FileNotFoundException;
import java.util.Scanner;
import java.util.regex.Matcher;
import java.util.regex.Pattern;

public class ReadabilityScore {
    public static void main(String[] args) {

        File file = new File("C:\\Users\\HP\\Downloads\\in.txt");//gets doc from comp
        StringBuilder text = new StringBuilder();

        int SentencesInText = 0;
        int WordsInText = 0;
        String NoSpace;
        int CharachtersInText = 0;
        int Syllables;
        int Polysyllables;

        try {
            Scanner scanner = new Scanner(file);
            while (scanner.hasNext()) {
                text.append(scanner.nextLine());
            }
        } catch (FileNotFoundException e) {
            System.out.println("No file found");
        }

        String[] NumberOfSentences = text.toString().split("[.!?]+\\s*");
        SentencesInText += NumberOfSentences.length;

        String[] Words = text.toString().split("\\s+|\\p{Z}");
        WordsInText += Words.length;

        NoSpace = text.toString().replace(" ", "");
        CharachtersInText += NoSpace.length();

        Syllables = countSyllables(text.toString());
        Polysyllables = countPolysyllables(text.toString());

        PrintAll(WordsInText, SentencesInText, CharachtersInText, Syllables, Polysyllables);

        ScoreSwitch(CharachtersInText, WordsInText, SentencesInText, Syllables, Polysyllables);

        AverageAge(CharachtersInText, WordsInText, SentencesInText, Polysyllables, Syllables);
    }

    static void PrintAll (int WordsInText, int SentencesInText, int CharachtersInText, int Syllables, int Polysyllables) {

        System.out.println("Words: " + WordsInText);
        System.out.println("Sentences: " + SentencesInText);
        System.out.println("Characters: " + CharachtersInText);
        System.out.println("Syllables: " + Syllables);
        System.out.println("Polysyllables: " + Polysyllables);
        System.out.println("Enter the score you want to calculate (ARI, FK, SMOG, CL, all):");
    }

    public static void ScoreSwitch(int chars, int words, int sent, int syllables, int polly){
        Scanner sc = new Scanner(System.in);
        double AutomatedScore;
        double FleschKindcaidScore;
        double SimpleScore;
        double ColemanLiauScore;
        String sw = sc.next();
        switch (sw) {
            case "ARI" -> {
                AutomatedScore = AutomatedScoreCount(chars, words, sent);
                AutomatedScorePrint(AutomatedScore);
            }
            case "FK" -> {
                FleschKindcaidScore = FleschKindcaidScoreCount(words, sent, syllables);
                FleschKindcaidScorePrint(FleschKindcaidScore);
            }
            case "SMOG" -> {
                SimpleScore = SimpleScoreCount(sent, polly);
                SimpleScorePrint(SimpleScore);
            }
            case "CL" -> {
                ColemanLiauScore = ColemanLiauScoreCount(chars, sent, words);
                ColemanLiauScorePrint(ColemanLiauScore);
            }
            case "all" -> {
                AutomatedScore = AutomatedScoreCount(chars, words, sent);
                AutomatedScorePrint(AutomatedScore);
                FleschKindcaidScore = FleschKindcaidScoreCount(words, sent, syllables);
                FleschKindcaidScorePrint(FleschKindcaidScore);
                SimpleScore = SimpleScoreCount(sent, polly);
                SimpleScorePrint(SimpleScore);
                ColemanLiauScore = ColemanLiauScoreCount(chars, sent, words);
                ColemanLiauScorePrint(ColemanLiauScore);
            }
        }
    }

    public static int countSyllables(String text) {

        String i = "(?i)[aeiou]{2,3}|[aiouy]|\\b([^aeiou .]*)e\\b|e[^ !?:;,]"; //"(?i)a[^aeiou]|i[^aeiou]|o[^aeiou]|u[^aeiou]|y[^aeiou]|e[^. ,!?aiou]|\\b([^aeiou .]*)e\\b";
        Matcher m = Pattern.compile(i).matcher(text);
        int count = 0;

        while (m.find()) {
            count++;
        }
        return Math.max(count, 1);
    }

    public static int countPolysyllables(String text) {

        String i = "(?i)([aeiou][^\\s.]+[aeiou][^\\s.]+[aioue][^\\s])";
        Matcher m = Pattern.compile(i).matcher(text);
        int count = 0;

        while (m.find()) {
            count++;
        }
        return Math.max(count, 1);
    }

    public static void AverageAge(int chars, int words, int sent, int polly, int syllables) {
        double AveAge = (double)(GetTheAge(AutomatedScoreCount(chars, words, sent)) + GetTheAge(FleschKindcaidScoreCount(words, sent, syllables)) +
                GetTheAge(SimpleScoreCount(sent, polly)) + GetTheAge(ColemanLiauScoreCount(chars, sent, words))) / 4;
        System.out.printf("\nThis text should be understood in average by %.2f-year-olds.\n", AveAge);
    }

    public static double AutomatedScoreCount(int chars, int words, int sent) {
        return (4.71 * ((double) chars / (double) words) + 0.5 * ((double) words / (double) sent) - 21.43);
    }
    public static void AutomatedScorePrint(double AutomatedScore) {
        int Age = GetTheAge(AutomatedScore);
        System.out.printf("Automated Readability Index: %.2f (about %d-year-olds).\n", AutomatedScore, Age);
    }

    public static double FleschKindcaidScoreCount(int words, int sent, int syllablles) {
        return 0.39 * (double)words / (double)sent + 11.8 * (double)syllablles / (double)words - 15.59;
    }

    public static void FleschKindcaidScorePrint(double FleschKindcaidScore) {
        int Age = GetTheAge(FleschKindcaidScore);
        System.out.printf("Flesch–Kincaid readability tests: %.2f (about %d-year-olds).\n", FleschKindcaidScore, Age);
    }

    public static double SimpleScoreCount(int sent, int polly) {
        return 1.043 * Math.sqrt((double)polly * 30 / (double)sent) + 3.1291;
    }

    public static void SimpleScorePrint(double SimpleScore) {
        int Age = GetTheAge(SimpleScore);
        System.out.printf("Simple Measure of Gobbledygook: %.2f (about %d-year-olds).\n", SimpleScore, Age);
    }

    public static double ColemanLiauScoreCount(int chars, int sent, int words) {
        return 0.0588 * ((double)chars / (double)words * 100) - 0.296 * ((double)sent /(double)words * 100) - 15.8;
    }

    public static void ColemanLiauScorePrint(double ColemanLiauScore) {
        int Age = GetTheAge(ColemanLiauScore);
        System.out.printf("Coleman–Liau index: %.2f (about %d-year-olds).\n", ColemanLiauScore, Age);
    }

    public static int GetTheAge(double Score) {
        return Math.round(Score) == 1.0 ? 6 :
                Math.round(Score) == 2.0 ? 7 :
                        Math.round(Score) == 3.0 ? 9 :
                                Math.round(Score) == 4.0 ? 10 :
                                        Math.round(Score) == 5.0 ? 11 :
                                                Math.round(Score) == 6.0 ? 12 :
                                                        Math.round(Score) == 7.0 ? 13 :
                                                                Math.round(Score) == 8.0 ? 14 :
                                                                        Math.round(Score) == 9.0 ? 15 :
                                                                                Math.round(Score) == 10.0 ? 16 :
                                                                                        Math.round(Score) == 11.0 ? 17 :
                                                                                                Math.round(Score) == 12.0 ? 18 : 24;

    }
}
/*
    replaceAll("e\\b", "")
.replaceAll("you", "a")
        .replaceAll("[aeiouy]{2}", "a")
        .replaceAll(" th "," a ")
        .replaceAll(",","")
        .replaceAll(" w "," a ")
        .replaceAll("[0-9]+", "a")
        .replaceAll("[^aeiouy]", "")

 */
