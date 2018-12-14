module.exports = function (context, request) {
    context.done(null, {status: 200, body: process.env["secret"]});
};