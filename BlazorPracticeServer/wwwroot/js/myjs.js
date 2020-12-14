function functionName(message) {
    console.log("from my js" + message)
}

function dotnetStaticInvocation() {
    DotNet.invokeMethodAsync("BlazorPracticeServer", "GetCurrentCount")
        .then(result => { // when c# method has a return value you use .them(result=>{something})
            console.log("count from javascript" + result)
        });
}

function dotnetInstanceInvocation(dotnetHelper) {
    dotnetHelper.invokeMethodAsync("IncrementCount");
}