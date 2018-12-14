module.exports = function (context, req) {
    context.res = {
        status: 200,
        body: process.env["secret"]
    };
    context.done();
};