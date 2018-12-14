module.exports = function (context, req) {
    return { body: process.env["secret"] };
};