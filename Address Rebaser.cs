void Rebase(int tobase)//rebase function with 1 argument
{
    if (tobase == 0)//check if int is null
    {
        return "ERROR_NULL_RETURNED";//nothing runs
    }
    else
    {
        int aslr = 4194304;
        if (aslr > tobase)//check if aslr is greater then tobase
        {
            return "INCORRECT ADDRESS?";
        }
        else
        {
            int result = aslr - tobase;
            MessageBox("Rebased: " + result.ToString());//finalize the results
            //if results are negative your stupid
        }
    }
}

Rebase(8715584);//run the function (this is example address)
