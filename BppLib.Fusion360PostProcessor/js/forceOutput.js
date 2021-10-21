/** Force output of X, Y, and Z on next output. */
function forceXYZ() {
 xOutput.reset();
 yOutput.reset();
 zOutput.reset();
}
/** Force output of A, B, and C on next output. */
function forceABC() {
 aOutput.reset();
 bOutput.reset();
 cOutput.reset();
}
/** Force output of F on next output. */
function forceFeed() {
 currentFeedId = undefined;
 feedOutput.reset();
}
/** Force output of X, Y, Z, A, B, C, and F on next output. */
function forceAny() {
 forceXYZ();
 forceABC();
 forceFeed();
}