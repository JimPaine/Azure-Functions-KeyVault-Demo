module.exports = function (context, request) {
    return {
        body: process.env["secret"]
    };
};