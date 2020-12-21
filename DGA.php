<?php
function DGA($year,$month,$day){
	$domain = "";
	for($i = 0; $i < 15;$i++){
		$year = (($year ^ 8 * $year) >> 11) ^ (($year & 0xFFFFFFF0) << 17);
		$month = (($month ^ 4 * $month) >> 25) ^ 16 * ($month & 0xFFFFFFF8);
		$day = (($day ^ ($day << 13)) >> 19) ^ (($day & 0xFFFFFFFE) << 12);
		$domain .= chr((($year ^ $month ^ $day) % 25) + 97);
	}
}
echo DGA(1999,9,9).".TLD";
