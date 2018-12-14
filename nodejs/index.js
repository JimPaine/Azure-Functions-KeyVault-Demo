module.exports = function (context) {
    context.res = {
        status: 200,
        body: process.env["secret"]
    };
    context.done();
};